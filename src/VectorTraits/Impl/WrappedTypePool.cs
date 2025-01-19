using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="WrappedType"/> Pool. It is used to solve the problem of reflection at AOT (WrappedType 池. 它用于解决反射在AOT时的问题).
    /// </summary>
    /// <remarks>
    /// <para>Step 1, register the type using methods such as <see cref="Register"/> (第1步, 使用 Register 等方法来注册类型).</para>
    /// <para>Step 2, use <see cref="TryGet"/> or <see cref="Find"/> method to get the WrappedType according to the Type (第2步, 使用 TryGet或Find方法, 根据 Type 获取 WrappedType).</para>
    /// </remarks>
    /// <seealso cref="WrappedType"/>
    public class WrappedTypePool {
        /// <summary>
        /// Gets a shared instance (获取共享实例).
        /// </summary>
        public static WrappedTypePool Shared { get; } = new WrappedTypePool();

        private readonly IDictionary<Type, WrappedType> _list;

        /// <summary>
        /// Get list (取得列表).
        /// </summary>
        public IReadOnlyDictionary<Type, WrappedType> List { 
            get { 
                return (IReadOnlyDictionary<Type, WrappedType>)_list;
            } 
        }

        /// <summary>
        /// Create WrappedTypePool.
        /// </summary>
        public WrappedTypePool() : this(new ConcurrentDictionary<Type, WrappedType>()) {
        }

        /// <summary>
        /// Create WrappedTypePool, use list.
        /// </summary>
        public WrappedTypePool(IDictionary<Type, WrappedType> list) {
            _list = list;
        }

        /// <summary>
        /// Register (注册).
        /// </summary>
        /// <param name="type">The type (类型).</param>
        public void Register(WrappedType type) {
            if (_list is ConcurrentDictionary<Type, WrappedType> list) {
                list.TryAdd(type.Type, type);
            } else {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
                _list.TryAdd(type.Type, type);
#else
                if (!_list.ContainsKey(type.Type)) {
                    _list.Add(type.Type, type);
                }
#endif
            }
        }

        /// <summary>
        /// Register all (注册所有).
        /// </summary>
        /// <param name="types">Type list (类型列表).</param>
        public void RegisterAll(IEnumerable<WrappedType> types) {
            foreach (var p in types) {
                if (null == p) continue;
                Register(p);
            }
        }

        /// <summary>
        /// Register all (注册所有).
        /// </summary>
        /// <param name="types">Type list (类型列表).</param>
        public void RegisterAll(params WrappedType[] types) {
            RegisterAll(types as IEnumerable<WrappedType>);
        }

        /// <summary>
        /// Try get value (尝试取得值).
        /// </summary>
        /// <param name="src">Source type (源类型).</param>
        /// <param name="dst">Destination value (目标值).</param>
        /// <returns>Return true for success, otherwise for failure (返回true为成功，否则为失败).</returns>
        public bool TryGet(Type src, out WrappedType? dst) {
            return _list.TryGetValue(src, out dst);
        }

        /// <summary>
        /// Find value (查找值).
        /// </summary>
        /// <param name="src">Source type (源类型).</param>
        /// <returns>Returns the value found on success, null on failure (成功时返回所找到的值, 失败时返回 null).</returns>
        public WrappedType? Find(Type src) {
            WrappedType? rt;
            if (!TryGet(src, out rt)) {
                rt = null;
            }
            return rt;
        }
    }
}

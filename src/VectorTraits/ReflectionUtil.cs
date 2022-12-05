using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Reflection util.
    /// </summary>
    public static class ReflectionUtil {
        // GetIsSupported - ParameterTypes
        private static readonly Type[] GetIsSupported_ParameterTypes = {
            typeof(bool)
        };
        // GetIsSupported - ParameterValues
        private static readonly object[] GetIsSupported_ParameterValues = {
            false
        };

        /// <summary>
        /// Searches for the public method with the specified name (搜索具有指定名称的公共方法).
        /// </summary>
        /// <param name="atype">The type (当前类型).</param>
        /// <param name="name">The string containing the name of the public method to get (包含要获取的公共方法的名称的字符串).</param>
        /// <returns>An object that represents the public method with the specified name, if found; otherwise, null (表示具有指定名称的公共方法的对象（如果找到的话）；否则为 null).</returns>
        public static MethodInfo? GetMethod(Type atype, string name) {
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_0_OR_GREATER
            return atype.GetMethod(name);
#else
            foreach(MethodInfo method in atype.GetRuntimeMethods()) {
                if (name.Equals(method.Name)) {
                    return method;
                }
            }
            return null;
#endif
        }

        /// <summary>
        /// Get static method list and output <paramref name="callback"/> (取得静态方法列表并输出到  <paramref name="callback"/> ).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="callback">Output callback (输出的回调).</param>
        /// <param name="types">Source type list (源类型列表).</param>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method count (返回方法数量)</returns>
        public static int GetMethodListCallback<T>(Action<T> callback, IEnumerable<Type> types, params string[] methodNames) where T : Delegate {
            int rt = 0;
            Type tType = typeof(T);
            MethodInfo? tMethod = GetMethod(tType, "Invoke");
            if (null == tMethod) return rt;
            ParameterInfo[] parameterInfos = tMethod.GetParameters();
            Type[] parameterTypes = new Type[parameterInfos.Length];
            for (int i = 0; i < parameterInfos.Length; ++i) {
                parameterTypes[i] = parameterInfos[i].ParameterType;
            }
            foreach (Type tp in types) {
                if (null == tp) continue;
                // check.
                MethodInfo? getIsSupportedMethod = tp.GetRuntimeMethod("GetIsSupported", GetIsSupported_ParameterTypes);
                if (null == getIsSupportedMethod) continue;
                bool isSupported = (bool)getIsSupportedMethod.Invoke(null, GetIsSupported_ParameterValues)!;
                if (!isSupported) continue;
                // get.
                foreach (string methodName in methodNames) {
                    if (string.IsNullOrEmpty(methodName)) continue;
                    MethodInfo? method = tp.GetRuntimeMethod(methodName, parameterTypes);
                    if (null == method) continue;
                    T obj = (T)method.CreateDelegate(tType);
                    callback(obj);
                    ++rt;
                }
            }
            return rt;
        }

        /// <summary>
        /// Get static method list and fill (取得静态方法列表并填充).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="output">Output target (输出目标).</param>
        /// <param name="types">Source type list (源类型列表).</param>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method count (返回方法数量)</returns>
        public static int GetMethodListFill<T>(ICollection<T> output, IEnumerable<Type> types, params string[] methodNames) where T : Delegate {
            int rt = GetMethodListCallback(delegate (T x) {
                output.Add(x);
            }, types, methodNames);
            return rt;
        }

        /// <summary>
        /// Get static method list (取得静态方法列表).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="types">Source type list (源类型列表).</param>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method list (返回方法列表)</returns>
        public static List<T> GetMethodList<T>(IEnumerable<Type> types, params string[] methodNames) where T : Delegate {
            List<T> rt = new List<T>();
            int cnt = GetMethodListFill(rt, types, methodNames);
            if (cnt > 0) {
            }
            return rt;
        }

    }
}
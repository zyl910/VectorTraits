using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Reflection util (反射工具).
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
        /// Get short name of <see cref="Type"/> (取得 <see cref="Type"/> 的短名称).
        /// </summary>
        /// <param name="atype">The type (此类型).</param>
        /// <returns>Short name (短名称).</returns>
        public static string GetShortName(Type atype) {
            string namespaceName = atype.Namespace;
            string rt = atype.FullName.Substring(namespaceName.Length+1);
            return rt;
        }

        /// <summary>
        /// Get short name of <see cref="MethodInfo"/> with type (取得 <see cref="MethodInfo"/> 带类型的短名称).
        /// </summary>
        /// <param name="methodInfo">The method info (方法信息).</param>
        /// <returns>Short name (短名称).</returns>
        public static string GetShortNameWithType(MethodInfo methodInfo) {
            string rt = GetShortName(methodInfo.DeclaringType) + "." + methodInfo.Name;
            return rt;
        }

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
        /// Get parameter types (取得参数类型数组).
        /// </summary>
        /// <param name="methodInfo">The method info (方法信息).</param>
        /// <returns>Rerurns parameter types (返回参数类型数组).</returns>
        public static Type[] GetParameterTypes(MethodInfo methodInfo) {
            ParameterInfo[] parameterInfos = methodInfo.GetParameters();
            Type[] parameterTypes = new Type[parameterInfos.Length];
            for (int i = 0; i < parameterInfos.Length; ++i) {
                parameterTypes[i] = parameterInfos[i].ParameterType;
            }
            return parameterTypes;
        }

        /// <summary>
        /// Type invoke <see cref="IBaseTraits.GetIsSupported"/> method (对类型调用  <see cref="IBaseTraits.GetIsSupported"/> 方法).
        /// </summary>
        /// <param name="atype">Target type (目标类型.).</param>
        /// <returns>Returns the value of <see cref="IBaseTraits.GetIsSupported"/> method (返回 GetIsSupported 方法的值).</returns>
        public static bool TypeInvokeGetIsSupported(Type atype) {
            MethodInfo? getIsSupportedMethod = atype.GetRuntimeMethod("GetIsSupported", GetIsSupported_ParameterTypes);
            if (null == getIsSupportedMethod) return false;
            bool isSupported = (bool)getIsSupportedMethod.Invoke(null, GetIsSupported_ParameterValues)!;
            return isSupported;
        }

        /// <summary>
        /// Get supported method list and output <paramref name="callback"/> (取得支持的方法列表并输出到  <paramref name="callback"/> ).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="callback">Output callback (输出的回调).</param>
        /// <param name="checkType">Check type predicate (检查类型的谓词). Default value is <see cref="TypeInvokeGetIsSupported"/>.</param>
        /// <param name="types">Source type list (源类型列表).</param>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method count (返回方法数量)</returns>
        public static int GetSupportedMethodListCallback<T>(Action<T> callback, Predicate<Type>? checkType, IEnumerable<Type> types, params string[] methodNames) where T : Delegate {
            int rt = 0;
            if (null == checkType) checkType = TypeInvokeGetIsSupported;
            Type tType = typeof(T);
            MethodInfo? tMethod = GetMethod(tType, "Invoke");
            if (null == tMethod) return rt;
            Type[] parameterTypes = GetParameterTypes(tMethod);
            foreach (Type tp in types) {
                if (null == tp) continue;
                // check.
                bool isSupported = checkType(tp);
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
        /// Get supported method list and output <paramref name="callback"/> (取得支持的方法列表并输出到  <paramref name="callback"/> ).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="callback">Output callback (输出的回调).</param>
        /// <param name="types">Source type list (源类型列表).</param>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method count (返回方法数量)</returns>
        public static int GetSupportedMethodListCallback<T>(Action<T> callback, IEnumerable<Type> types, params string[] methodNames) where T : Delegate {
            int rt = GetSupportedMethodListCallback(callback, TypeInvokeGetIsSupported, types, methodNames);
            return rt;
        }

        /// <summary>
        /// Get supported method list and fill (取得支持的方法列表并填充).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="output">Output target (输出目标).</param>
        /// <param name="types">Source type list (源类型列表).</param>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method count (返回方法数量)</returns>
        public static int GetSupportedMethodListFill<T>(ICollection<T> output, IEnumerable<Type> types, params string[] methodNames) where T : Delegate {
            int rt = GetSupportedMethodListCallback(delegate (T x) {
                output.Add(x);
            }, types, methodNames);
            return rt;
        }

        /// <summary>
        /// Get supported method list (取得支持的方法列表).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="types">Source type list (源类型列表).</param>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method list (返回方法列表)</returns>
        public static List<T> GetSupportedMethodList<T>(IEnumerable<Type> types, params string[] methodNames) where T : Delegate {
            List<T> rt = new List<T>();
            int cnt = GetSupportedMethodListFill(rt, types, methodNames);
            if (cnt > 0) {
            }
            return rt;
        }

    }
}
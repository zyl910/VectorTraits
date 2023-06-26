using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Zyl.VectorTraits.Impl {
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
        public static string? GetShortName(Type? atype) {
            if (null == atype) return null;
            string? rt = atype.FullName;
            if (null == rt) return rt;
            string? namespaceName = atype.Namespace;
            if (null == namespaceName) return rt;
            rt = rt.Substring(namespaceName.Length + 1);
            return rt;
        }

        /// <summary>
        /// Get short name of <see cref="MethodInfo"/> with type (取得 <see cref="MethodInfo"/> 带类型的短名称).
        /// </summary>
        /// <param name="methodInfo">The method info (方法信息).</param>
        /// <returns>Short name (短名称).</returns>
        public static string GetShortNameWithType(MethodInfo? methodInfo) {
            if (null == methodInfo) return "";
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

        /// <summary>
        /// Get methods group (取得方法组).
        /// </summary>
        /// <param name="aType">The type (类型).</param>
        /// <returns>Returns methods group (返回方法组).</returns>
        public static SortedDictionary<string, List<MethodInfo>> GetMethodGroup(Type aType) {
            var methods = aType.GetRuntimeMethods();
            var groupBy = methods.GroupBy(o => o.Name)
                .ToDictionary(g => g.Key, g => g.ToList());
            var dict = new SortedDictionary<string, List<MethodInfo>>(groupBy);
            return dict;
        }

        /// <summary>
        /// Check if the parameter list of the methods is the same.
        /// </summary>
        /// <param name="a">The first value (第一个值).</param>
        /// <param name="b">The second value (第二个值).</param>
        /// <returns>Returns true if equal, otherwise false (若相等便返回true, 否则返回false).</returns>
        public static bool EqualsParametersType(MethodInfo a, MethodInfo b) {
            if (a == b) return true;
            if (null == a) return false;
            if (null == b) return false;
            ParameterInfo[] parameters1 = a.GetParameters();
            ParameterInfo[] parameters2 = b.GetParameters();
            if (parameters1.Length != parameters2.Length) {
                return false;
            }
            for (int i = 0; i < parameters1.Length; i++) {
                Type parameterType1 = parameters1[i].ParameterType;
                Type parameterType2 = parameters2[i].ParameterType;
                if (!parameterType1.Equals(parameterType2)) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Default of OnMissed functon (默认的 OnMissed 函数).
        /// </summary>
        /// <param name="methodStatic">The method of a static class (静态类的方法).</param>
        /// <param name="methodInterface">The method of a static class (接口的方法).</param>
        /// <param name="userdata">The userdata.</param>
        /// <returns>Returns true if you want to ignore <paramref name="methodStatic"/>, false otherwise (若需忽略 <paramref name="methodStatic"/>，便返回true, 否则会返回false).</returns>
        /// <seealso cref="CheckBindMethods"/>
        public static bool OnMissed_Default(MethodInfo methodStatic, MethodInfo? methodInterface, object? userdata) {
            bool isIgnore = (null == methodInterface); // If it is not in the method list of the interface, it is ignored.
            _ = methodStatic;
            _ = userdata;
            return isIgnore;
        }

        /// <summary>
        /// Check the binding of the method set on <paramref name="funcEquals"/> (基于 <paramref name="funcEquals"/> 检查方法集的绑定.
        /// </summary>
        /// <param name="funcEquals">The callback function to determine equality (判断相等的回调函数). Prototype: <c>bool isEquals = funcEquals(MethodInfo a, MethodInfo b)</c>. e.g. <see cref="EqualsParametersType"/> </param>
        /// <param name="staticType">The type of a static class (静态类的类型).</param>
        /// <param name="objectType">The type of a object class (对象类的类型).</param>
        /// <param name="interfaceMethodsDictionary">The methods of interface (接口类型的方法集合). If it is not null, the <paramref name="staticType"/> is checked in the scope of the method set of the interface (如果它非空，则在接口的方法集范围内检查 <paramref name="staticType"/> ).</param>
        /// <param name="onMissed">The callback function for finding a missed method (找到未命中方法时的回调函数). Prototype: <c>bool isIgnore = onMissed(MethodInfo methodStatic, MethodInfo? methodInterface, object? userdata)</c>. If it is null, <see cref="OnMissed_Default"/> will be used.</param>
        /// <param name="userdata">The userdata.</param>
        /// <returns>Returns the number of missed methods. Specifically, the number of times when <paramref name="onMissed"/> returns false (返回未命中方法的个数。具体来说，是 <paramref name="onMissed"/> 返回false的次数).</returns>
        public static int CheckBindMethodsOn(Func<MethodInfo, MethodInfo, bool> funcEquals, Type staticType, Type objectType, IDictionary<string, List<MethodInfo>>? interfaceMethodsDictionary, Func<MethodInfo, MethodInfo?, object?, bool>? onMissed = null, object? userdata = null) {
            int rt = 0;
            if (null == onMissed) onMissed = OnMissed_Default;
            var staticDictionaryBy = staticType.GetRuntimeMethods()
                .Where(o => staticType.Equals(o.DeclaringType))
                .GroupBy(o => o.Name)
                .ToDictionary(g => g.Key, g => g.ToList());
            var staticDictionary = new SortedDictionary<string, List<MethodInfo>>(staticDictionaryBy);
            var objectDictionary = objectType.GetRuntimeMethods()
                .Where(o => objectType.Equals(o.DeclaringType))
                .GroupBy(o => o.Name)
                .ToDictionary(g => g.Key, g => g.ToList());
            foreach (KeyValuePair<string, List<MethodInfo>> kvp in staticDictionary) {
                string methodName = kvp.Key;
                if (null == kvp.Value || kvp.Value.Count <= 0) continue;
                List<MethodInfo>? objectMethods;
                if (!objectDictionary.TryGetValue(methodName, out objectMethods)) objectMethods = null;
                List<MethodInfo>? interfaceMethods = null;
                if (null != interfaceMethodsDictionary) {
                    if (!interfaceMethodsDictionary.TryGetValue(methodName, out interfaceMethods)) interfaceMethods = null;
                }
                // methodStatic.
                foreach (MethodInfo? methodStatic in kvp.Value) {
                    if (null == methodStatic) continue;
                    MethodInfo? objectMethod = null;
                    if (null != objectMethods) {
                        objectMethod = objectMethods.FirstOrDefault(x => funcEquals(methodStatic, x));
                    }
                    bool isFound = null != objectMethod;
                    if (!isFound) {
                        MethodInfo? interfaceMethod = null;
                        if (null != interfaceMethods) {
                            interfaceMethod = interfaceMethods.FirstOrDefault(x => funcEquals(methodStatic, x));
                        }
                        bool isIgnore = onMissed(methodStatic, interfaceMethod, userdata);
                        if (!isIgnore) {
                            ++rt;
                        }
                    }
                }
            }
            return rt;
        }

        /// <summary>
        /// Check the binding of the method set, i.e. whether the method of the <paramref name="staticType"/> is missing from the <paramref name="objectType"/> (检查方法集的绑定，即在 <paramref name="objectType"/> 中是否缺少 <paramref name="staticType"/> 的方法). e.g. <see cref="VectorTraitsBase.Statics"/> and <see cref="VectorTraitsAbstract"/> . It has the interfaceMethodsDictionary parameter.
        /// </summary>
        /// <param name="staticType">The type of a static class (静态类的类型).</param>
        /// <param name="objectType">The type of a object class (对象类的类型).</param>
        /// <param name="interfaceMethodsDictionary">The methods of interface (接口类型的方法集合). If it is not null, the <paramref name="staticType"/> is checked in the scope of the method set of the interface (如果它非空，则在接口的方法集范围内检查 <paramref name="staticType"/> ).</param>
        /// <param name="onMissed">The callback function for finding a missed method (找到未命中方法时的回调函数). Prototype: <c>bool isIgnore = onMissed(MethodInfo methodStatic, MethodInfo? methodInterface, object? userdata)</c>. If it is null, <see cref="OnMissed_Default"/> will be used.</param>
        /// <param name="userdata">The userdata.</param>
        /// <returns>Returns the number of missed methods. Specifically, the number of times when <paramref name="onMissed"/> returns false (返回未命中方法的个数。具体来说，是 <paramref name="onMissed"/> 返回false的次数).</returns>
        public static int CheckBindMethods(Type staticType, Type objectType, IDictionary<string, List<MethodInfo>>? interfaceMethodsDictionary, Func<MethodInfo, MethodInfo?, object?, bool>? onMissed = null, object? userdata = null) {
            int rt = CheckBindMethodsOn(EqualsParametersType, staticType, objectType, interfaceMethodsDictionary, onMissed, userdata);
            return rt;
        }

        /// <summary>
        /// Check the binding of the method set, i.e. whether the method of the <paramref name="staticType"/> is missing from the <paramref name="objectType"/> (检查方法集的绑定，即在 <paramref name="objectType"/> 中是否缺少 <paramref name="staticType"/> 的方法). e.g. <see cref="VectorTraitsBase.Statics"/> and <see cref="VectorTraitsAbstract"/> .
        /// </summary>
        /// <param name="staticType">The type of a static class (静态类的类型).</param>
        /// <param name="objectType">The type of a object class (对象类的类型).</param>
        /// <param name="interfaceType">The type of interface (接口的类型). If it is not null, the <paramref name="staticType"/> is checked in the scope of the method set of the interface (如果它非空，则在接口的方法集范围内检查 <paramref name="staticType"/> ).</param>
        /// <param name="onMissed">The callback function for finding a missed method (找到未命中方法时的回调函数). Prototype: <c>bool isIgnore = onMissed(MethodInfo methodStatic, MethodInfo? methodInterface, object? userdata)</c>. If it is null, <see cref="OnMissed_Default"/> will be used.</param>
        /// <param name="userdata">The userdata.</param>
        /// <returns>Returns the number of missed methods. Specifically, the number of times when <paramref name="onMissed"/> returns false (返回未命中方法的个数。具体来说，是 <paramref name="onMissed"/> 返回false的次数).</returns>
        public static int CheckBindMethods(Type staticType, Type objectType, Type? interfaceType, Func<MethodInfo, MethodInfo?, object?, bool>? onMissed = null, object? userdata = null) {
            SortedDictionary<string, List<MethodInfo>>? interfaceMethodsDictionary = null;
            if (null != interfaceType) {
                interfaceMethodsDictionary = GetMethodGroup(interfaceType);
            }
            int rt = CheckBindMethods(staticType, objectType, interfaceMethodsDictionary, onMissed, userdata);
            return rt;
        }

    }
}
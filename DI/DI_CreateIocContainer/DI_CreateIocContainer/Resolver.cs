using System;
using System.Collections.Generic;
using System.Linq;

namespace DI_CreateIocContainer
{
    public class Resolver
    {

        private Dictionary<Type, Type> dependenyMap = new Dictionary<Type, Type>();


        public void Register<TFrom, TTo>()
        {
            dependenyMap.Add(typeof(TFrom), typeof(TTo));
        }


        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private object Resolve(Type interfaceType)
        {
            Type classType;

            if (!dependenyMap.TryGetValue(interfaceType, out classType))
            {
                throw new Exception($"Could not resolve type {interfaceType.FullName}");
            } 

            var ctr = classType.GetConstructors().First();

            var ctrParameter = ctr.GetParameters();

            if (!ctrParameter.Any())
            {
                return Activator.CreateInstance(classType);
            }

            List<object> parameters = new List<object>();

            foreach (var item in ctrParameter)
            {
                parameters.Add(Resolve(item.ParameterType));
            }
            return ctr.Invoke(parameters.ToArray());
        }

    }
}

using Autofac;
using Controllers;
using Presenters;
using System;
using System.Reflection;
using UseCases;
using UseCases.EvaluateProperty;

namespace GUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainPage>();
            builder.RegisterType<EvaluatePropertyController>().As<IEvaluatePropertyController>();
            builder.RegisterType<EvaluateProperty>().As<IEvaluatePropertyInput>();
            builder.RegisterType<EvaluatePropertyPresenter>().As<IEvaluatePropertyOutput>();
            builder.RegisterType<PropertyValuationPage>().As<IEvaluatePropertyFrontEnd>();
            

            return builder.Build();
        }
    }
}

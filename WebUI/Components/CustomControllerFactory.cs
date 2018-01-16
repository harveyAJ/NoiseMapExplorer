
namespace WebUI.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using DataAccess;
    using System.Web.Mvc;

    public class CustomControllerFactory : DefaultControllerFactory
    {
        private readonly IRepository _repository;

        public CustomControllerFactory()
        {
            _repository = new DataAccess.Mock.MockRepository();
        }

        protected override IController GetControllerInstance(
            System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            var controllerName = requestContext.RouteData.Values["controller"].ToString();

            IController controller = null;
            if (controllerName == "Account")
            {
                controller = Activator.CreateInstance(controllerType) as Controller;
            }
            else //controllerName == "Home"
            {
                controller = Activator.CreateInstance(controllerType, new[] { _repository }) as Controller;
            }
            return controller;
        }

        public override void ReleaseController(IController controller)
        {
            IDisposable dispose = controller as IDisposable;
            if (dispose != null)
            {
                dispose.Dispose();
            }
        }

    }
}
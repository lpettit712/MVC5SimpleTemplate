using System.Web.Mvc;
using SiteServices.ViewModelProviders;
using Contract;
using Web.Core;

namespace Site.Controllers
{
    public class DeploymentController : Controller
    {
        private readonly IDeploymentViewModelProvider _deploymentViewModelProvider;
        private readonly ILoggingService _loggingService;

        public DeploymentController(IDeploymentViewModelProvider deploymentViewModelProvider, ILoggingService loggingService)
        {
            _deploymentViewModelProvider = deploymentViewModelProvider;
            _loggingService = loggingService;
        }

        public ActionResult Index()
        {
            return View(_deploymentViewModelProvider.GetDeploymentsViewModel());
        }

        public ActionResult Create()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Contract.Models.Deployment deployment)
        {
            _loggingService.Info("Deployment is being created.");
            return RedirectToAction("Index");
        }
    }
}
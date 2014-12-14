using System.Web.Mvc;
using SiteServices.ViewModelProviders;

namespace Site.Controllers
{
    public class DeploymentController : Controller
    {
        private readonly IDeploymentViewModelProvider _deploymentViewModelProvider;

        public DeploymentController(IDeploymentViewModelProvider deploymentViewModelProvider)
        {
            _deploymentViewModelProvider = deploymentViewModelProvider;
        }

        public ActionResult Index()
        {
            return View(_deploymentViewModelProvider.GetDeploymentsViewModel());
        }
    }
}
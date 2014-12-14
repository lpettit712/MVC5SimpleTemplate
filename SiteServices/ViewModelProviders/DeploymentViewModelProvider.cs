using System.Collections.Generic;
using Contract.Models;
using Core;
using SiteServices.ViewModels;

namespace SiteServices.ViewModelProviders
{
    public interface IDeploymentViewModelProvider : IDependency
    {
        DeploymentsViewModel GetDeploymentsViewModel();
    }
    public class DeploymentViewModelProvider : IDeploymentViewModelProvider
    {
        public DeploymentsViewModel GetDeploymentsViewModel()
        {
            var deployment = new Deployment
            {
                Description = "Test Deployment description",
                DeploymentId = 3,
                Name = "Test Deployment"
            };

            return new DeploymentsViewModel {Deployments = new List<Deployment> {deployment}};
        }
    }


}

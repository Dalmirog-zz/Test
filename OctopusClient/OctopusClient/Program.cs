using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octopus.Client;

namespace OctopusClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string OctopusURL = "http://dalmiropc";
            string OctopusAPIKey = "API-LQ5HY1KOYHSCQKVYAK2DFK8X4";
            var endpoint = new Octopus.Client.OctopusServerEndpoint(OctopusURL, OctopusAPIKey);
            var repository = new Octopus.Client.OctopusRepository(endpoint);

            Octopus.Client.Model.LifecycleResource Lifecycle = new Octopus.Client.Model.LifecycleResource();
            Lifecycle.Name = "NewLifecycle";
            
            Octopus.Client.Model.LifecycleResource newlifecycle = repository.Lifecycles.Create(Lifecycle);
        }
    }
}

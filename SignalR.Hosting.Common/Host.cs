﻿namespace SignalR.Hosting.Common
{
    public class Host
    {
        private readonly IDependencyResolver _resolver;

        public Host()
            : this(GlobalHost.DependencyResolver)
        {

        }

        public Host(IDependencyResolver resolver)
        {
            _resolver = resolver;
        }

        /// <summary>
        /// Provides access to the <see cref="IDependencyResolver"/> for this host.
        /// </summary>
        public IDependencyResolver DependencyResolver
        {
            get
            {
                return _resolver;
            }
        }

        /// <summary>
        /// Provides access to the <see cref="IConnectionManager"/> for this host.
        /// </summary>
        public IConnectionManager ConnectionManager
        {
            get
            {
                return DependencyResolver.Resolve<IConnectionManager>();
            }
        }

        /// <summary>
        /// Provides access to the <see cref="IConfigurationManager"/> for this host.
        /// </summary>
        public IConfigurationManager Configuration
        {
            get
            {
                return DependencyResolver.Resolve<IConfigurationManager>();
            }
        }
    }
}
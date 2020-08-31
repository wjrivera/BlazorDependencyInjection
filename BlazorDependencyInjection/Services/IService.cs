using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDependencyInjection.Services
{
    public interface IService
    {
        string GetToken();
    }

    public interface ISingletonService : IService { }
    public interface IScopedService : IService { }
    public interface ITransientService : IService { }

    public class SingletonService : ISingletonService
    {
        private readonly string _token;
        public SingletonService()
        {
            _token = Guid.NewGuid().ToString();
        }

        public string GetToken() => _token;
    }

    public class ScopedService : IScopedService
    {
        private readonly string _token;
        public ScopedService()
        {
            _token = Guid.NewGuid().ToString();
        }

        public string GetToken() => _token;
    }

    public class TransientService : ITransientService
    {
        private readonly string _token;
        public TransientService()
        {
            _token = Guid.NewGuid().ToString();
        }

        public string GetToken() => _token;
    }
}

using EmployeeManagement.Models;
using EmployeeManagement.View;
using EmployeeManagement.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;
using Unity;

namespace EmployeeManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<ILogger, Logger>();
            unityContainer.RegisterType<IEmployeeRepository, EmployeeRepository>();
            unityContainer.RegisterType<IEmployeesViewModel, EmployeesViewModel>();
            unityContainer.RegisterType<IEmployeeViewModel, EmployeeViewModel>();

            unityContainer.Resolve<EmployeesView>().Show();
        }
    }
}

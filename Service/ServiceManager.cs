﻿using AutoMapper;
using Contracts;
using Entities.ConfigurationModels;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IEmployeeService> _employeeService;
        private readonly Lazy<IAuthenticationService> _authenticationSerivice;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
logger, IMapper mapper, IEmployeeLinks employeeLinks, IOptions<JwtConfiguration> configuration, UserManager<User> userManager)
        {
            _companyService = new Lazy<ICompanyService>(() => new CompanyService(repositoryManager, logger,  mapper));
            _employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repositoryManager, logger,  mapper, employeeLinks));
            _authenticationSerivice = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
        }

        public ICompanyService CompanyService => _companyService.Value;

        public IEmployeeService EmployeeService => _employeeService.Value;
    
        public IAuthenticationService AuthenticationService => _authenticationSerivice.Value;
    }
}

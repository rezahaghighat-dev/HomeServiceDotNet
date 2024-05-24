﻿using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class ServiceRequestAppService : IServiceRequestAppService
    {
        #region Fields
        private readonly IServiceRequestService _serviceRequestService;
        #endregion

        #region Ctors
        public ServiceRequestAppService(IServiceRequestService serviceRequestService)
        {
            _serviceRequestService = serviceRequestService;
        }

        #endregion

        #region Implementations
        public async Task<ServiceRequest> CreateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken)
            => await _serviceRequestService.CreateServiceRequest(serviceRequestDto, cancellationToken);

        public async Task<ServiceRequestDto> GetServiceRequestById(int serviceId, CancellationToken cancellationToken)
            => await _serviceRequestService.GetServiceRequestById(serviceId, cancellationToken);

        public async Task<List<ServiceRequestDto>> GetServiceRequests(CancellationToken cancellationToken)
            => await _serviceRequestService.GetServiceRequests(cancellationToken);

        //public async Task<ServiceRequest> HardDeleteServiceRequest(int serviceId, CancellationToken cancellationToken)
        //    => await _serviceRequestService.HardDeleteServiceRequest(serviceId, cancellationToken);

        public async Task<ServiceRequestSoftDeleteDto> SoftDeleteServiceRequest(int serviceId, CancellationToken cancellationToken)
            => await _serviceRequestService.SoftDeleteServiceRequest(serviceId, cancellationToken);

        public async Task<ServiceRequestDto> UpdateServiceRequest(ServiceRequestDto serviceRequestDto, CancellationToken cancellationToken)
            => await _serviceRequestService.UpdateServiceRequest(serviceRequestDto, cancellationToken);

        public async Task<ServiceRequestChangeStatusDto> ChangeServiceRequestStatus(ServiceRequestChangeStatusDto newStatus, CancellationToken cancellationToken)
            => await _serviceRequestService.ChangeServiceRequestStatus(newStatus, cancellationToken);

		public async Task<List<ServiceRequestDto>> GetCustomerServiceRequests(int customerId, CancellationToken cancellationToken)
		    => await _serviceRequestService.GetCustomerServiceRequests(customerId, cancellationToken);
		#endregion
	}
}

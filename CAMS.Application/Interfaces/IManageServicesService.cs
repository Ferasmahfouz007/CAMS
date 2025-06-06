﻿using CAMS.Application.DTOs;
using CAMS.Data.Models;
using System.Security.Claims;

namespace CAMS.Application.Interfaces
{
    public interface IManageServicesService
    {
        Task<List<ServiceDTO>> GetAllServices();
        Task<List<ServiceDTO>> GetAvailableServicesInAddAppointment(ClaimsPrincipal user);
        Task addService(ServiceDTO serviceDTO,ClaimsPrincipal user);
        Task updateService(ServiceDTO serviceDTO,ClaimsPrincipal user);
        Task<ServiceDTO> getService(int? id);
        //ServiceDTO getSelectedServiceDetails(ServiceDTO service);
        Task<bool> DoesTheServiceHaveAppointments(int? serviceId);
        Task DeleteService(ServiceDTO serviceDTO, ClaimsPrincipal user);
        Task<ServiceDTO> getServiceById(int? id);

        string GetMostBookedServiceName();
        Task<List<string>> GetServicesNames();
        int GetTotalServices();
        Task<ServiceWithActiveAppointmentsDTO> getServiceWithActiveAppointments(int? id);
    }  
}

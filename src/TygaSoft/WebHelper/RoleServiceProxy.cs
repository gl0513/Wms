﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.5485
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://asp.net/ApplicationServices/v200", ConfigurationName="RoleService")]
public interface RoleService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://asp.net/ApplicationServices/v200/RoleService/GetRolesForCurrentUser", ReplyAction="http://asp.net/ApplicationServices/v200/RoleService/GetRolesForCurrentUserRespons" +
        "e")]
    string[] GetRolesForCurrentUser();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://asp.net/ApplicationServices/v200/RoleService/IsCurrentUserInRole", ReplyAction="http://asp.net/ApplicationServices/v200/RoleService/IsCurrentUserInRoleResponse")]
    bool IsCurrentUserInRole(string role);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface RoleServiceChannel : RoleService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class RoleServiceClient : System.ServiceModel.ClientBase<RoleService>, RoleService
{
    
    public RoleServiceClient()
    {
    }
    
    public RoleServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public RoleServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RoleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RoleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string[] GetRolesForCurrentUser()
    {
        return base.Channel.GetRolesForCurrentUser();
    }
    
    public bool IsCurrentUserInRole(string role)
    {
        return base.Channel.IsCurrentUserInRole(role);
    }
}


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// Created via this command line: "C:\Users\phili\AppData\Roaming\MscrmTools\XrmToolBox\Plugins\DLaB.EarlyBoundGenerator\crmsvcutil.exe" /namespace:"CrmEarlyBound" /SuppressGeneratedCodeAttribute /out:"C:\Users\phili\AppData\Roaming\MscrmTools\XrmToolBox\Settings\EBG\OptionSets.cs" /codecustomization:"DLaB.CrmSvcUtilExtensions.OptionSet.CustomizeCodeDomService,DLaB.CrmSvcUtilExtensions" /codegenerationservice:"DLaB.CrmSvcUtilExtensions.OptionSet.CustomCodeGenerationService,DLaB.CrmSvcUtilExtensions" /codewriterfilter:"DLaB.CrmSvcUtilExtensions.OptionSet.CodeWriterFilterService,DLaB.CrmSvcUtilExtensions" /namingservice:"DLaB.CrmSvcUtilExtensions.NamingService,DLaB.CrmSvcUtilExtensions" /metadataproviderservice:"DLaB.CrmSvcUtilExtensions.BaseMetadataProviderService,DLaB.CrmSvcUtilExtensions" /connectionstring:"AuthType=ClientSecret;Url=https://orgea88443b.api.crm4.dynamics.com;ClientId=183590e6-147a-44bf-8cee-02907f55f0d7;ClientSecret=*************************************;" 
//------------------------------------------------------------------------------

namespace CrmEarlyBound
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ComponentState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Deleted", 2)]
		Deleted = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Deleted Unpublished", 3)]
		DeletedUnpublished = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Published", 0)]
		Published = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Unpublished", 1)]
		Unpublished = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum IsInherited
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Direct User (Basic) access level and Team privileges", 1)]
		DirectUser_BasicaccesslevelandTeamprivileges = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Team privileges only", 0)]
		Teamprivilegesonly = 0,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum PriceLevel_FreightTermsCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum PriceLevel_PaymentMethodCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum PriceLevel_ShippingMethodCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum PriceLevel_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 100001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 100002,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Product_ProductStructure
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Product", 0)]
		Product = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Product Bundle", 2)]
		ProductBundle = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Product Family", 1)]
		ProductFamily = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Product_ProductTypeCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Flat Fees", 3)]
		FlatFees = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Miscellaneous Charges", 1)]
		MiscellaneousCharges = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Sales Inventory", 0)]
		SalesInventory = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Services", 2)]
		Services = 3,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Product_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Draft", 2)]
		Draft = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Retired", 1)]
		Retired = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Under Revision", 3)]
		UnderRevision = 3,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ProductAssociation_ProductIsRequired
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Optional", 0)]
		Optional = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Required", 1)]
		Required = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ProductAssociation_PropertyCustomizationStatus
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Available", 1)]
		Available = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Not Available", 0)]
		NotAvailable = 0,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ProductAssociation_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Draft", 2)]
		Draft = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("DraftActive", 3)]
		DraftActive = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ProductPriceLevel_PricingMethodCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Currency Amount", 0)]
		CurrencyAmount = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Percent Margin - Current Cost", 3)]
		PercentMarginCurrentCost = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Percent Margin - Standard Cost", 5)]
		PercentMarginStandardCost = 6,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Percent Markup - Current Cost", 2)]
		PercentMarkupCurrentCost = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Percent Markup - Standard Cost", 4)]
		PercentMarkupStandardCost = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Percent of List", 1)]
		PercentofList = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ProductPriceLevel_QuantitySellingCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("No Control", 0)]
		NoControl = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Whole", 1)]
		Whole = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Whole and Fractional", 2)]
		WholeandFractional = 3,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ProductPriceLevel_RoundingOptionCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Ends in", 0)]
		Endsin = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Multiple of", 1)]
		Multipleof = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ProductPriceLevel_RoundingPolicyCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Down", 2)]
		Down = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("None", 0)]
		None = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("To Nearest", 3)]
		ToNearest = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Up", 1)]
		Up = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_AccessMode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Administrative", 1)]
		Administrative = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Delegated Admin", 5)]
		DelegatedAdmin = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Non-interactive", 4)]
		Noninteractive = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Read", 2)]
		Read = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Read-Write", 0)]
		ReadWrite = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Support User", 3)]
		SupportUser = 3,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_Address1_AddressTypeCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_Address1_ShippingMethodCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_Address2_AddressTypeCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_Address2_ShippingMethodCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_CALType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Administrative", 1)]
		Administrative = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Basic", 2)]
		Basic = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Device Basic", 4)]
		DeviceBasic = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Device Enterprise", 8)]
		DeviceEnterprise = 8,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Device Essential", 6)]
		DeviceEssential = 6,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Device Professional", 3)]
		DeviceProfessional = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Enterprise", 7)]
		Enterprise = 7,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Essential", 5)]
		Essential = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Field Service", 11)]
		FieldService = 11,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Professional", 0)]
		Professional = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Project Service", 12)]
		ProjectService = 12,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Sales", 9)]
		Sales = 9,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Service", 10)]
		Service = 10,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_DeletedState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Not deleted", 0)]
		Notdeleted = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Soft deleted", 1)]
		Softdeleted = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_EmailRouterAccessApproval
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Approved", 1)]
		Approved = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Empty", 0)]
		Empty = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Pending Approval", 2)]
		PendingApproval = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Rejected", 3)]
		Rejected = 3,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_IncomingEmailDeliveryMethod
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Forward Mailbox", 3)]
		ForwardMailbox = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Microsoft Dynamics 365 for Outlook", 1)]
		MicrosoftDynamics365forOutlook = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("None", 0)]
		None = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Server-Side Synchronization or Email Router", 2)]
		ServerSideSynchronizationorEmailRouter = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_InviteStatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Invitation Accepted", 4)]
		InvitationAccepted = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Invitation Expired", 3)]
		InvitationExpired = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Invitation Near Expired", 2)]
		InvitationNearExpired = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Invitation Not Sent", 0)]
		InvitationNotSent = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Invitation Rejected", 5)]
		InvitationRejected = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Invitation Revoked", 6)]
		InvitationRevoked = 6,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Invited", 1)]
		Invited = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_OutgoingEmailDeliveryMethod
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Microsoft Dynamics 365 for Outlook", 1)]
		MicrosoftDynamics365forOutlook = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("None", 0)]
		None = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Server-Side Synchronization or Email Router", 2)]
		ServerSideSynchronizationorEmailRouter = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_PreferredAddressCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mailing Address", 0)]
		MailingAddress = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Other Address", 1)]
		OtherAddress = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_PreferredEmailCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_PreferredPhoneCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Home Phone", 2)]
		HomePhone = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Main Phone", 0)]
		MainPhone = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mobile Phone", 3)]
		MobilePhone = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Other Phone", 1)]
		OtherPhone = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Team_MembershipType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Guests", 3)]
		Guests = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Members", 1)]
		Members = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Members and guests", 0)]
		Membersandguests = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Owners", 2)]
		Owners = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Team_TeamType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("AAD Office Group", 3)]
		AADOfficeGroup = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("AAD Security Group", 2)]
		AADSecurityGroup = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Access", 1)]
		Access = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Owner", 0)]
		Owner = 0,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum TransactionCurrency_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum UoMSchedule_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum appaction_ClientType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Browser", 0, "#0000ff")]
		Browser = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mobile", 1, "#0000ff")]
		Mobile = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mail App", 2, "#0000ff")]
		MailApp = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum msdyn_msdyn_requirementrelationship_msdyn_resourcegroupings
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Organizational Unit", 0, "#0000ff")]
		OrganizationalUnit = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Related Resource Pools", 1, "#0000ff")]
		RelatedResourcePools = 192350001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Location", 2, "#0000ff")]
		Location = 192350002,
	}
}

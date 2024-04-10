using System;
using System.Collections.Generic;
using System.Linq;

namespace TextingSystem.Services.ViewModels.Backend.Configuration
{
    //public enum UserRoles
    //{
    //    Administrator,
    //    Production,
    //    Shipment,
    //    Approval,
    //    General,
    //    AllowBlindShip,
    //    BlanketPricing,
    //    CombineShipping,
    //    CustomPricingAccess,
    //    DisableDeltaCargo,
    //    DisablePickUpFee,
    //    DisableTagOptions,
    //    EditCustomerGroup,
    //    EditTaxableExpDate,
    //    EditUpdateRun,
    //    EmailPromotion,
    //    GeneratePromoCode,
    //    IssueCredit,
    //    MakeModifyEstimates,
    //    ModifyOrderWithoutCharge,
    //    MoveStatusPostOIP,
    //    SetClientToPO,
    //    SetJobToReprint,
    //    ShippingOnAccount,
    //    ViewOrderTotalInList,
    //    POManager,
    //    WalkIn
    //}

    [System.Serializable]
    public class CmsRoles
    {
        public const string AdminRoleName = "administrator";
        public const string ApprovalRoleName = "approval";
        public const string GeneralRoleName = "general";
        public const string ShipmentRoleName = "shipment";
        public const string ProductionRoleName = "production";
        public const string AllowBlindShipRoleName = "allowblindship";
        public const string BlanketPricingRoleName = "blanketpricing";
        public const string CombineShippingRoleName = "combineshipping";
        public const string CustomPricingAccessRoleName = "custompricingaccess";
        public const string DisableDeltaCargoRoleName = "disabledeltacargo";
        public const string DisablePickUpFeeRoleName = "disablepickupfee";
        public const string DisableTagOptionsRoleName = "disabletagoptions";
        public const string EditCustomerGroupRoleName = "editcustomergroup";
        public const string EditTaxableExpDateRoleName = "edittaxableexpdate";
        public const string EditUpdateRunRoleName = "editupdaterun";
        public const string EmailPromotionRoleName = "emailpromotion";
        public const string GeneratePromoCodeRoleName = "generatepromocode";
        public const string IssueCreditRoleName = "issuecredit";
        public const string MakeModifyEstimatesRoleName = "makemodifyestimates";
        public const string ModifyOrderWithoutChargeRoleName = "modifyorderwithoutcharge";
        public const string MoveStatusPostOIPRoleName = "movestatuspostoip";
        public const string SetClientToPORoleName = "setclienttopo";
        public const string SetJobToReprintRoleName = "setjobtoreprint";
        public const string ShippingOnAccountRoleName = "shippingonaccount";
        public const string ViewOrderTotalInListRoleName = "viewordertotalinlist";
        public const string ClientViewInOrderPageRoleName = "clientviewinorderpage";
        public const string WalkInRoleName = "walkin";
        public const string ExemptBillingMismatchRoleName = "exemptbillingmismatch";
        public const string POManagerRoleName = "pomanager";
        public const string UseCheapestTurnaroundRoleName = "usecheapestturnaround";
        public const string CustomerShippingPaddingsRoleName = "customershippingpaddings";
        public const string RemoveOrderFromRunBatchRoleName = "removeorderfromrunbatch";
        public const string BlogsWriterName = "blogswriter";

        public const string AllCmsRoles = "administrator,approval,general,shipment,production," +
                                          "allowblindship,blanketpricing,combineshipping,custompricingaccess," +
                                          "disabledeltacargo,disablepickupfee,disabletagoptions,editcustomergroup," +
                                          "edittaxableexpdate,editupdaterun,emailpromotion,generatepromocode,issuecredit," +
                                          "makemodifyestimates,modifyorderwithoutcharge,movestatuspostoip,setclienttopo," +
                                          "setjobtoreprint,shippingonaccount,viewordertotalinlist,clientviewinorderpage," +
                                          "walkin,exemptbillingmismatch,pomanager,usecheapestturnaround,customershippingpaddings,removeorderfromrunbatch,blogswriter";

        public void ParseRoles(string[] roles)
        {
            IsAdministrator = roles.Contains(AdminRoleName, StringComparer.OrdinalIgnoreCase);
            IsApproval = roles.Contains(ApprovalRoleName, StringComparer.OrdinalIgnoreCase);
            IsGeneral = roles.Contains(GeneralRoleName, StringComparer.OrdinalIgnoreCase);
            IsShipment = roles.Contains(ShipmentRoleName, StringComparer.OrdinalIgnoreCase);
            IsProduction = roles.Contains(ProductionRoleName, StringComparer.OrdinalIgnoreCase);
            IsBlogWriter = roles.Contains(BlogsWriterName, StringComparer.OrdinalIgnoreCase);

            HasAccess_AllowBlindShip = roles.Contains(AllowBlindShipRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_BlanketPricing = roles.Contains(BlanketPricingRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_CombineShipping = roles.Contains(CombineShippingRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_CustomPricingAccess = roles.Contains(CustomPricingAccessRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_DisableDeltaCargo = roles.Contains(DisableDeltaCargoRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_DisablePickUpFee = roles.Contains(DisablePickUpFeeRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_DisableTagOptions = roles.Contains(DisableTagOptionsRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_EditCustomerGroup = roles.Contains(EditCustomerGroupRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_EditTaxableExpDate = roles.Contains(EditTaxableExpDateRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_EditUpdateRun = roles.Contains(EditUpdateRunRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_EmailPromotion = roles.Contains(EmailPromotionRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_GeneratePromoCode = roles.Contains(GeneratePromoCodeRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_IssueCredit = roles.Contains(IssueCreditRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_MakeModifyEstimates = roles.Contains(MakeModifyEstimatesRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_ModifyOrderWithoutCharge = roles.Contains(ModifyOrderWithoutChargeRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_MoveStatusPostOIP = roles.Contains(MoveStatusPostOIPRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_SetClientToPO = roles.Contains(SetClientToPORoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_SetJobToReprint = roles.Contains(SetJobToReprintRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_ShippingOnAccount = roles.Contains(ShippingOnAccountRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_ViewOrderTotalInList = roles.Contains(ViewOrderTotalInListRoleName, StringComparer.OrdinalIgnoreCase);

            HasAccess_ClientViewInOrderPage = roles.Contains(ClientViewInOrderPageRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_WalkIn = roles.Contains(WalkInRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_ExemptBillingMismatch = roles.Contains(ExemptBillingMismatchRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_POManager = roles.Contains(POManagerRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_UseCheapestTurnaround = roles.Contains(UseCheapestTurnaroundRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_CustomerShippingPaddings = roles.Contains(CustomerShippingPaddingsRoleName, StringComparer.OrdinalIgnoreCase);
            HasAccess_RemoveOrderFromRunBatch = roles.Contains(RemoveOrderFromRunBatchRoleName, StringComparer.OrdinalIgnoreCase);
        }

        public bool IsAdministrator { get; set; }
        public bool IsProduction { get; set; }
        public bool IsShipment { get; set; }
        public bool IsApproval { get; set; }
        public bool IsGeneral { get; set; }
        public bool IsBlogWriter { get; set; }
        public bool HasAccess_AllowBlindShip { get; set; }
        public bool HasAccess_BlanketPricing { get; set; }
        public bool HasAccess_CombineShipping { get; set; }
        public bool HasAccess_CustomPricingAccess { get; set; }
        public bool HasAccess_DisableDeltaCargo { get; set; }
        public bool HasAccess_DisablePickUpFee { get; set; }
        public bool HasAccess_DisableTagOptions { get; set; }
        public bool HasAccess_EditCustomerGroup { get; set; }
        public bool HasAccess_EditTaxableExpDate { get; set; }
        public bool HasAccess_EditUpdateRun { get; set; }
        public bool HasAccess_EmailPromotion { get; set; }
        public bool HasAccess_GeneratePromoCode { get; set; }
        public bool HasAccess_IssueCredit { get; set; }
        public bool HasAccess_MakeModifyEstimates { get; set; }
        public bool HasAccess_ModifyOrderWithoutCharge { get; set; }
        public bool HasAccess_MoveStatusPostOIP { get; set; }
        public bool HasAccess_SetClientToPO { get; set; }
        public bool HasAccess_SetJobToReprint { get; set; }
        public bool HasAccess_ShippingOnAccount { get; set; }
        public bool HasAccess_ViewOrderTotalInList { get; set; }
        public bool HasAccess_ClientViewInOrderPage { get; set; }
        public bool HasAccess_WalkIn { get; set; }
        public bool HasAccess_ExemptBillingMismatch { get; set; }
        public bool HasAccess_POManager { get; set; }
        public bool HasAccess_UseCheapestTurnaround { get; set; }
        public bool HasAccess_CustomerShippingPaddings { get; set; }
        public bool HasAccess_RemoveOrderFromRunBatch { get; set; }

        public IEnumerable<string> GetRoles()
        {
            if (IsBlogWriter)
            {
                yield return BlogsWriterName;
            }

            if (IsAdministrator)
            {
                yield return AdminRoleName;
            }

            if (IsApproval)
            {
                yield return ApprovalRoleName;
            }

            if (IsGeneral)
            {
                yield return GeneralRoleName;
            }

            if (IsProduction)
            {
                yield return ProductionRoleName;
            }

            if (IsShipment)
            {
                yield return ShipmentRoleName;
            }

            if (HasAccess_AllowBlindShip)
            {
                yield return AllowBlindShipRoleName;
            }

            if (HasAccess_BlanketPricing)
            {
                yield return BlanketPricingRoleName;
            }

            if (HasAccess_CombineShipping)
            {
                yield return CombineShippingRoleName;
            }

            if (HasAccess_CustomPricingAccess)
            {
                yield return CustomPricingAccessRoleName;
            }

            if (HasAccess_DisableDeltaCargo)
            {
                yield return DisableDeltaCargoRoleName;
            }

            if (HasAccess_DisablePickUpFee)
            {
                yield return DisablePickUpFeeRoleName;
            }

            if (HasAccess_DisableTagOptions)
            {
                yield return DisableTagOptionsRoleName;
            }

            if (HasAccess_EditCustomerGroup)
            {
                yield return EditCustomerGroupRoleName;
            }

            if (HasAccess_EditTaxableExpDate)
            {
                yield return EditTaxableExpDateRoleName;
            }

            if (HasAccess_EditUpdateRun)
            {
                yield return EditUpdateRunRoleName;
            }

            if (HasAccess_EmailPromotion)
            {
                yield return EmailPromotionRoleName;
            }

            if (HasAccess_GeneratePromoCode)
            {
                yield return GeneratePromoCodeRoleName;
            }

            if (HasAccess_IssueCredit)
            {
                yield return IssueCreditRoleName;
            }

            if (HasAccess_MakeModifyEstimates)
            {
                yield return MakeModifyEstimatesRoleName;
            }

            if (HasAccess_ModifyOrderWithoutCharge)
            {
                yield return ModifyOrderWithoutChargeRoleName;
            }

            if (HasAccess_MoveStatusPostOIP)
            {
                yield return MoveStatusPostOIPRoleName;
            }

            if (HasAccess_SetClientToPO)
            {
                yield return SetClientToPORoleName;
            }

            if (HasAccess_SetJobToReprint)
            {
                yield return SetJobToReprintRoleName;
            }

            if (HasAccess_ShippingOnAccount)
            {
                yield return ShippingOnAccountRoleName;
            }

            if (HasAccess_ViewOrderTotalInList)
            {
                yield return ViewOrderTotalInListRoleName;
            }

            if (HasAccess_ClientViewInOrderPage)
            {
                yield return ClientViewInOrderPageRoleName;
            }

            if (HasAccess_WalkIn)
            {
                yield return WalkInRoleName;
            }

            if (HasAccess_ExemptBillingMismatch)
            {
                yield return ExemptBillingMismatchRoleName;
            }

            if (HasAccess_POManager)
            {
                yield return POManagerRoleName;
            }

            if (HasAccess_UseCheapestTurnaround)
            {
                yield return UseCheapestTurnaroundRoleName;
            }

            if (HasAccess_CustomerShippingPaddings)
            {
                yield return CustomerShippingPaddingsRoleName;
            }

            if (HasAccess_RemoveOrderFromRunBatch)
            {
                yield return RemoveOrderFromRunBatchRoleName;
            }
        }

    }
}


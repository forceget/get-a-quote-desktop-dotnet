using AirPort;
using City;
using Country;
using Location;
using SimpleDeveloper.InAndOutModel;
using State;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Token
{
    public class MToken
    {
        public class Form
        {

        }

        public class FilterForm:MFilterBase 
        {
          public string Email { get; set; }
          public string PasswordHash { get; set; }
        }
       
        public class Response
        {
            public Root Data { get; set; }
            public int Status { get; set; } = 200;
            public List<string> StatusTexts { get; set; } = new List<string>();
            public dynamic Total { get; set; }
            public long Count { get; set; } = 0;

        }

        #region root
        public class BillingNotificationSettingType
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class CompanyInfo
        {
            public object id { get; set; }
            public object userId { get; set; }
            public object taxEINNumber { get; set; }
            public string name { get; set; }
            public object contactInfo { get; set; }
            public object countryId { get; set; }
            public object stateId { get; set; }
            public object address { get; set; }
            public object cityId { get; set; }
            public int internationalLogisticsTerms { get; set; }
            public int domesticTruckTerms { get; set; }
            public int domesticTruckLimit { get; set; }
            public int internationalLogisticsLimit { get; set; }
            public object createdDate { get; set; }
            public object updateDate { get; set; }
            public object updateBy { get; set; }
            public object validation { get; set; }
            public object city { get; set; }
            public object country { get; set; }
            public object state { get; set; }
            public object locations { get; set; }
            public object products { get; set; }
            public object companyTeams { get; set; }
            public bool isMember { get; set; }
            public object latitude { get; set; }
            public object longitude { get; set; }
            public int activeOfferCount { get; set; }
            public int activeShipmentCount { get; set; }
            public int totalShipmentCount { get; set; }
            public object affiliatePartnerId { get; set; }
            public object affiliatePartner { get; set; }
            public object salesRepresentativeId { get; set; }
            public object salesRepresentative { get; set; }
            public int totalCustomerCount { get; set; }
            public int activeCustomerCount { get; set; }
            public object customerSegmentId { get; set; }
            public object customerSegment { get; set; }
            public object serviceTypes { get; set; }
            public object channel { get; set; }
            public int numberOfSKU { get; set; }
            public int numberOfCarton { get; set; }
            public int numberOfUnit { get; set; }
            public int numberOfPallets { get; set; }
            public int numberOfCeilPallets { get; set; }
            public int lateFeeRate { get; set; }
            public object monthlyAverageShipment { get; set; }
            public object monthlyAverageShipmentId { get; set; }
            public object eventId { get; set; }
            public object @event { get; set; }
            public int isRegularCustomer { get; set; }
            public int isForceRegular { get; set; }
            public object billingInfo { get; set; }
            public bool isDontDeliverList { get; set; }
        }

        public class CompanyTeam
        {
            public int id { get; set; }
            public string userId { get; set; }
            public object user { get; set; }
            public string companyId { get; set; }
            public CompanyInfo companyInfo { get; set; }
            public string jobTitleId { get; set; }
            public JobTitle jobTitle { get; set; }
            public int roleId { get; set; }
            public object role { get; set; }
            public string mobileNumber { get; set; }
            public bool editAuthority { get; set; }
        }

        public class CorrespondanceNotificationSettingType
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class DocumentSubmissionNotificationSettingType
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class InventoryNotificationSettingType
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Item
        {
            public string id { get; set; }
            public string email { get; set; }
            public int isEmailConfirmed { get; set; }
            public object passwordHash { get; set; }
            public string phoneNumber { get; set; }
            public int isPhoneNumberConfirmed { get; set; }
            public int isTwoFactorEnabled { get; set; }
            public DateTime lockoutEndDateUtc { get; set; }
            public int isLockoutEnabled { get; set; }
            public int accessFailedCount { get; set; }
            public string userName { get; set; }
            public List<CompanyTeam> companyTeams { get; set; }
            public int isMember { get; set; }
            public string uniqueNickname { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public object terms { get; set; }
            public object fromQs { get; set; }
            public string profilePhoto { get; set; }
            public List<NotificationSetting> notificationSettings { get; set; }
            public string token { get; set; }
            public object commissionType { get; set; }
            public object commissionValue { get; set; }
            public object paymentInfo { get; set; }
            public object lastOnlineDate { get; set; }
            public object eventId { get; set; }
            public object @event { get; set; }
            public string roleGroupTypeId { get; set; }
            public RoleGroupType roleGroupType { get; set; }
        }

        public class JobTitle
        {
            public string id { get; set; }
            public string name { get; set; }
            public object description { get; set; }
            public int sort { get; set; }
        }

        public class NotificationSetting
        {
            public int id { get; set; }
            public object userId { get; set; }
            public int offer { get; set; }
            public int shipment { get; set; }
            public int billing { get; set; }
            public int documentSubmission { get; set; }
            public int correspondance { get; set; }
            public int inventory { get; set; }
            public object createdTime { get; set; }
            public object updatedTime { get; set; }
            public OfferNotificationSettingType offerNotificationSettingType { get; set; }
            public ShipmentNotificationSettingType shipmentNotificationSettingType { get; set; }
            public BillingNotificationSettingType billingNotificationSettingType { get; set; }
            public DocumentSubmissionNotificationSettingType documentSubmissionNotificationSettingType { get; set; }
            public CorrespondanceNotificationSettingType correspondanceNotificationSettingType { get; set; }
            public InventoryNotificationSettingType inventoryNotificationSettingType { get; set; }
        }

        public class OfferNotificationSettingType
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class RoleGroupType
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Root
        {
            public int status { get; set; }
            public object statusText { get; set; }
            public List<object> statusTexts { get; set; }
            public Item item { get; set; }
            public object total { get; set; }
            public int count { get; set; }
        }

        public class ShipmentNotificationSettingType
        {
            public int id { get; set; }
            public string name { get; set; }
        }


        #endregion
    }
}

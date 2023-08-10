# IO.Swagger.Model.PlatformSettingsUpdate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteTitle** | **string** | The title of the e-commerce site. | 
**SiteDescription** | **string** | A brief description or tagline for the platform. | 
**MaintenanceMode** | **bool?** | Flag to indicate if the site is in maintenance mode. True means the site is in maintenance mode, false means it&#x27;s live. | [optional] 
**DefaultCurrency** | **string** | The default currency for product pricing and transactions. | [optional] 
**PaymentMethods** | **List&lt;string&gt;** |  | [optional] 
**ShippingConfig** | [**PlatformSettingsUpdateShippingConfig**](PlatformSettingsUpdateShippingConfig.md) |  | [optional] 
**OtherSettings** | **Dictionary&lt;string, Object&gt;** | Any other miscellaneous settings that don&#x27;t fit into the above categories. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


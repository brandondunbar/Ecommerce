# IO.Swagger.Model.MonitoringMetric
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetricId** | **long?** | Unique identifier for the metric entry. | 
**MetricName** | **string** | Name of the monitoring metric (e.g., \&quot;CPU_Usage\&quot;, \&quot;Response_Time\&quot;, \&quot;Memory_Usage\&quot;). | 
**Timestamp** | **DateTime?** | The exact time when the metric was measured. | 
**Value** | **float?** | The value of the monitoring metric, often a percentage, time in milliseconds, or other unit relevant to the metric. | 
**Unit** | **string** | The unit of the metric value (e.g., \&quot;%\&quot;, \&quot;ms\&quot;, \&quot;MB\&quot;). | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Any other relevant metadata associated with the metric, such as resource details or related system information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


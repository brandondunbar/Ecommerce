# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.platform_settings_update_shipping_config_rates import PlatformSettingsUpdateShippingConfigRates  # noqa: F401,E501
from swagger_server import util


class PlatformSettingsShippingConfig(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, default_provider: str=None, rates: List[PlatformSettingsUpdateShippingConfigRates]=None):  # noqa: E501
        """PlatformSettingsShippingConfig - a model defined in Swagger

        :param default_provider: The default_provider of this PlatformSettingsShippingConfig.  # noqa: E501
        :type default_provider: str
        :param rates: The rates of this PlatformSettingsShippingConfig.  # noqa: E501
        :type rates: List[PlatformSettingsUpdateShippingConfigRates]
        """
        self.swagger_types = {
            'default_provider': str,
            'rates': List[PlatformSettingsUpdateShippingConfigRates]
        }

        self.attribute_map = {
            'default_provider': 'defaultProvider',
            'rates': 'rates'
        }
        self._default_provider = default_provider
        self._rates = rates

    @classmethod
    def from_dict(cls, dikt) -> 'PlatformSettingsShippingConfig':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The PlatformSettings_shippingConfig of this PlatformSettingsShippingConfig.  # noqa: E501
        :rtype: PlatformSettingsShippingConfig
        """
        return util.deserialize_model(dikt, cls)

    @property
    def default_provider(self) -> str:
        """Gets the default_provider of this PlatformSettingsShippingConfig.

        Default shipping provider.  # noqa: E501

        :return: The default_provider of this PlatformSettingsShippingConfig.
        :rtype: str
        """
        return self._default_provider

    @default_provider.setter
    def default_provider(self, default_provider: str):
        """Sets the default_provider of this PlatformSettingsShippingConfig.

        Default shipping provider.  # noqa: E501

        :param default_provider: The default_provider of this PlatformSettingsShippingConfig.
        :type default_provider: str
        """

        self._default_provider = default_provider

    @property
    def rates(self) -> List[PlatformSettingsUpdateShippingConfigRates]:
        """Gets the rates of this PlatformSettingsShippingConfig.


        :return: The rates of this PlatformSettingsShippingConfig.
        :rtype: List[PlatformSettingsUpdateShippingConfigRates]
        """
        return self._rates

    @rates.setter
    def rates(self, rates: List[PlatformSettingsUpdateShippingConfigRates]):
        """Sets the rates of this PlatformSettingsShippingConfig.


        :param rates: The rates of this PlatformSettingsShippingConfig.
        :type rates: List[PlatformSettingsUpdateShippingConfigRates]
        """

        self._rates = rates
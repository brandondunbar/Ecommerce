# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class ProductPriceHistoryItem(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, price: float=None, effective_date: datetime=None, reason: str=None):  # noqa: E501
        """ProductPriceHistoryItem - a model defined in Swagger

        :param price: The price of this ProductPriceHistoryItem.  # noqa: E501
        :type price: float
        :param effective_date: The effective_date of this ProductPriceHistoryItem.  # noqa: E501
        :type effective_date: datetime
        :param reason: The reason of this ProductPriceHistoryItem.  # noqa: E501
        :type reason: str
        """
        self.swagger_types = {
            'price': float,
            'effective_date': datetime,
            'reason': str
        }

        self.attribute_map = {
            'price': 'price',
            'effective_date': 'effectiveDate',
            'reason': 'reason'
        }
        self._price = price
        self._effective_date = effective_date
        self._reason = reason

    @classmethod
    def from_dict(cls, dikt) -> 'ProductPriceHistoryItem':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ProductPriceHistoryItem of this ProductPriceHistoryItem.  # noqa: E501
        :rtype: ProductPriceHistoryItem
        """
        return util.deserialize_model(dikt, cls)

    @property
    def price(self) -> float:
        """Gets the price of this ProductPriceHistoryItem.

        The price of the product at a specific point in time.  # noqa: E501

        :return: The price of this ProductPriceHistoryItem.
        :rtype: float
        """
        return self._price

    @price.setter
    def price(self, price: float):
        """Sets the price of this ProductPriceHistoryItem.

        The price of the product at a specific point in time.  # noqa: E501

        :param price: The price of this ProductPriceHistoryItem.
        :type price: float
        """

        self._price = price

    @property
    def effective_date(self) -> datetime:
        """Gets the effective_date of this ProductPriceHistoryItem.

        Date and time when this price became effective.  # noqa: E501

        :return: The effective_date of this ProductPriceHistoryItem.
        :rtype: datetime
        """
        return self._effective_date

    @effective_date.setter
    def effective_date(self, effective_date: datetime):
        """Sets the effective_date of this ProductPriceHistoryItem.

        Date and time when this price became effective.  # noqa: E501

        :param effective_date: The effective_date of this ProductPriceHistoryItem.
        :type effective_date: datetime
        """

        self._effective_date = effective_date

    @property
    def reason(self) -> str:
        """Gets the reason of this ProductPriceHistoryItem.

        Optional field denoting the reason for the price change (e.g., seasonal sale, supplier price change).  # noqa: E501

        :return: The reason of this ProductPriceHistoryItem.
        :rtype: str
        """
        return self._reason

    @reason.setter
    def reason(self, reason: str):
        """Sets the reason of this ProductPriceHistoryItem.

        Optional field denoting the reason for the price change (e.g., seasonal sale, supplier price change).  # noqa: E501

        :param reason: The reason of this ProductPriceHistoryItem.
        :type reason: str
        """

        self._reason = reason
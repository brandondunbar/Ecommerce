# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class InventoryItem(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, product_id: int=None, product_name: str=None, current_stock: int=None, restock_threshold: int=None, last_restock_date: datetime=None, next_restock_date: datetime=None, supplier: str=None, notes: str=None):  # noqa: E501
        """InventoryItem - a model defined in Swagger

        :param product_id: The product_id of this InventoryItem.  # noqa: E501
        :type product_id: int
        :param product_name: The product_name of this InventoryItem.  # noqa: E501
        :type product_name: str
        :param current_stock: The current_stock of this InventoryItem.  # noqa: E501
        :type current_stock: int
        :param restock_threshold: The restock_threshold of this InventoryItem.  # noqa: E501
        :type restock_threshold: int
        :param last_restock_date: The last_restock_date of this InventoryItem.  # noqa: E501
        :type last_restock_date: datetime
        :param next_restock_date: The next_restock_date of this InventoryItem.  # noqa: E501
        :type next_restock_date: datetime
        :param supplier: The supplier of this InventoryItem.  # noqa: E501
        :type supplier: str
        :param notes: The notes of this InventoryItem.  # noqa: E501
        :type notes: str
        """
        self.swagger_types = {
            'product_id': int,
            'product_name': str,
            'current_stock': int,
            'restock_threshold': int,
            'last_restock_date': datetime,
            'next_restock_date': datetime,
            'supplier': str,
            'notes': str
        }

        self.attribute_map = {
            'product_id': 'productId',
            'product_name': 'productName',
            'current_stock': 'currentStock',
            'restock_threshold': 'restockThreshold',
            'last_restock_date': 'lastRestockDate',
            'next_restock_date': 'nextRestockDate',
            'supplier': 'supplier',
            'notes': 'notes'
        }
        self._product_id = product_id
        self._product_name = product_name
        self._current_stock = current_stock
        self._restock_threshold = restock_threshold
        self._last_restock_date = last_restock_date
        self._next_restock_date = next_restock_date
        self._supplier = supplier
        self._notes = notes

    @classmethod
    def from_dict(cls, dikt) -> 'InventoryItem':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The InventoryItem of this InventoryItem.  # noqa: E501
        :rtype: InventoryItem
        """
        return util.deserialize_model(dikt, cls)

    @property
    def product_id(self) -> int:
        """Gets the product_id of this InventoryItem.

        Unique identifier for the product.  # noqa: E501

        :return: The product_id of this InventoryItem.
        :rtype: int
        """
        return self._product_id

    @product_id.setter
    def product_id(self, product_id: int):
        """Sets the product_id of this InventoryItem.

        Unique identifier for the product.  # noqa: E501

        :param product_id: The product_id of this InventoryItem.
        :type product_id: int
        """
        if product_id is None:
            raise ValueError("Invalid value for `product_id`, must not be `None`")  # noqa: E501

        self._product_id = product_id

    @property
    def product_name(self) -> str:
        """Gets the product_name of this InventoryItem.

        Name of the product.  # noqa: E501

        :return: The product_name of this InventoryItem.
        :rtype: str
        """
        return self._product_name

    @product_name.setter
    def product_name(self, product_name: str):
        """Sets the product_name of this InventoryItem.

        Name of the product.  # noqa: E501

        :param product_name: The product_name of this InventoryItem.
        :type product_name: str
        """
        if product_name is None:
            raise ValueError("Invalid value for `product_name`, must not be `None`")  # noqa: E501

        self._product_name = product_name

    @property
    def current_stock(self) -> int:
        """Gets the current_stock of this InventoryItem.

        The current stock level for the product.  # noqa: E501

        :return: The current_stock of this InventoryItem.
        :rtype: int
        """
        return self._current_stock

    @current_stock.setter
    def current_stock(self, current_stock: int):
        """Sets the current_stock of this InventoryItem.

        The current stock level for the product.  # noqa: E501

        :param current_stock: The current_stock of this InventoryItem.
        :type current_stock: int
        """
        if current_stock is None:
            raise ValueError("Invalid value for `current_stock`, must not be `None`")  # noqa: E501

        self._current_stock = current_stock

    @property
    def restock_threshold(self) -> int:
        """Gets the restock_threshold of this InventoryItem.

        The threshold at which a restock alert is triggered. When the current stock drops below this value, a restock might be necessary.  # noqa: E501

        :return: The restock_threshold of this InventoryItem.
        :rtype: int
        """
        return self._restock_threshold

    @restock_threshold.setter
    def restock_threshold(self, restock_threshold: int):
        """Sets the restock_threshold of this InventoryItem.

        The threshold at which a restock alert is triggered. When the current stock drops below this value, a restock might be necessary.  # noqa: E501

        :param restock_threshold: The restock_threshold of this InventoryItem.
        :type restock_threshold: int
        """

        self._restock_threshold = restock_threshold

    @property
    def last_restock_date(self) -> datetime:
        """Gets the last_restock_date of this InventoryItem.

        The date and time when the product was last restocked.  # noqa: E501

        :return: The last_restock_date of this InventoryItem.
        :rtype: datetime
        """
        return self._last_restock_date

    @last_restock_date.setter
    def last_restock_date(self, last_restock_date: datetime):
        """Sets the last_restock_date of this InventoryItem.

        The date and time when the product was last restocked.  # noqa: E501

        :param last_restock_date: The last_restock_date of this InventoryItem.
        :type last_restock_date: datetime
        """

        self._last_restock_date = last_restock_date

    @property
    def next_restock_date(self) -> datetime:
        """Gets the next_restock_date of this InventoryItem.

        Estimated date and time for the next restocking, if applicable.  # noqa: E501

        :return: The next_restock_date of this InventoryItem.
        :rtype: datetime
        """
        return self._next_restock_date

    @next_restock_date.setter
    def next_restock_date(self, next_restock_date: datetime):
        """Sets the next_restock_date of this InventoryItem.

        Estimated date and time for the next restocking, if applicable.  # noqa: E501

        :param next_restock_date: The next_restock_date of this InventoryItem.
        :type next_restock_date: datetime
        """

        self._next_restock_date = next_restock_date

    @property
    def supplier(self) -> str:
        """Gets the supplier of this InventoryItem.

        The supplier or manufacturer of the product.  # noqa: E501

        :return: The supplier of this InventoryItem.
        :rtype: str
        """
        return self._supplier

    @supplier.setter
    def supplier(self, supplier: str):
        """Sets the supplier of this InventoryItem.

        The supplier or manufacturer of the product.  # noqa: E501

        :param supplier: The supplier of this InventoryItem.
        :type supplier: str
        """

        self._supplier = supplier

    @property
    def notes(self) -> str:
        """Gets the notes of this InventoryItem.

        Any additional notes or comments about the inventory item.  # noqa: E501

        :return: The notes of this InventoryItem.
        :rtype: str
        """
        return self._notes

    @notes.setter
    def notes(self, notes: str):
        """Sets the notes of this InventoryItem.

        Any additional notes or comments about the inventory item.  # noqa: E501

        :param notes: The notes of this InventoryItem.
        :type notes: str
        """

        self._notes = notes

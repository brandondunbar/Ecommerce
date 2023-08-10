# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.address import Address  # noqa: F401,E501
from swagger_server.models.order_item import OrderItem  # noqa: F401,E501
from swagger_server import util


class Order(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, id: int=None, order_date: datetime=None, status: str=None, items: List[OrderItem]=None, total_amount: float=None, shipping_address: Address=None, payment_method: str=None, tracking_number: str=None):  # noqa: E501
        """Order - a model defined in Swagger

        :param id: The id of this Order.  # noqa: E501
        :type id: int
        :param order_date: The order_date of this Order.  # noqa: E501
        :type order_date: datetime
        :param status: The status of this Order.  # noqa: E501
        :type status: str
        :param items: The items of this Order.  # noqa: E501
        :type items: List[OrderItem]
        :param total_amount: The total_amount of this Order.  # noqa: E501
        :type total_amount: float
        :param shipping_address: The shipping_address of this Order.  # noqa: E501
        :type shipping_address: Address
        :param payment_method: The payment_method of this Order.  # noqa: E501
        :type payment_method: str
        :param tracking_number: The tracking_number of this Order.  # noqa: E501
        :type tracking_number: str
        """
        self.swagger_types = {
            'id': int,
            'order_date': datetime,
            'status': str,
            'items': List[OrderItem],
            'total_amount': float,
            'shipping_address': Address,
            'payment_method': str,
            'tracking_number': str
        }

        self.attribute_map = {
            'id': 'id',
            'order_date': 'orderDate',
            'status': 'status',
            'items': 'items',
            'total_amount': 'totalAmount',
            'shipping_address': 'shippingAddress',
            'payment_method': 'paymentMethod',
            'tracking_number': 'trackingNumber'
        }
        self._id = id
        self._order_date = order_date
        self._status = status
        self._items = items
        self._total_amount = total_amount
        self._shipping_address = shipping_address
        self._payment_method = payment_method
        self._tracking_number = tracking_number

    @classmethod
    def from_dict(cls, dikt) -> 'Order':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The Order of this Order.  # noqa: E501
        :rtype: Order
        """
        return util.deserialize_model(dikt, cls)

    @property
    def id(self) -> int:
        """Gets the id of this Order.

        Unique identifier for the order.  # noqa: E501

        :return: The id of this Order.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id: int):
        """Sets the id of this Order.

        Unique identifier for the order.  # noqa: E501

        :param id: The id of this Order.
        :type id: int
        """

        self._id = id

    @property
    def order_date(self) -> datetime:
        """Gets the order_date of this Order.

        Date and time when the order was placed.  # noqa: E501

        :return: The order_date of this Order.
        :rtype: datetime
        """
        return self._order_date

    @order_date.setter
    def order_date(self, order_date: datetime):
        """Sets the order_date of this Order.

        Date and time when the order was placed.  # noqa: E501

        :param order_date: The order_date of this Order.
        :type order_date: datetime
        """

        self._order_date = order_date

    @property
    def status(self) -> str:
        """Gets the status of this Order.

        Current status of the order.  # noqa: E501

        :return: The status of this Order.
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status: str):
        """Sets the status of this Order.

        Current status of the order.  # noqa: E501

        :param status: The status of this Order.
        :type status: str
        """
        allowed_values = ["pending", "processing", "shipped", "completed", "canceled"]  # noqa: E501
        if status not in allowed_values:
            raise ValueError(
                "Invalid value for `status` ({0}), must be one of {1}"
                .format(status, allowed_values)
            )

        self._status = status

    @property
    def items(self) -> List[OrderItem]:
        """Gets the items of this Order.

        List of products/items in the order.  # noqa: E501

        :return: The items of this Order.
        :rtype: List[OrderItem]
        """
        return self._items

    @items.setter
    def items(self, items: List[OrderItem]):
        """Sets the items of this Order.

        List of products/items in the order.  # noqa: E501

        :param items: The items of this Order.
        :type items: List[OrderItem]
        """

        self._items = items

    @property
    def total_amount(self) -> float:
        """Gets the total_amount of this Order.

        Total amount of the order.  # noqa: E501

        :return: The total_amount of this Order.
        :rtype: float
        """
        return self._total_amount

    @total_amount.setter
    def total_amount(self, total_amount: float):
        """Sets the total_amount of this Order.

        Total amount of the order.  # noqa: E501

        :param total_amount: The total_amount of this Order.
        :type total_amount: float
        """

        self._total_amount = total_amount

    @property
    def shipping_address(self) -> Address:
        """Gets the shipping_address of this Order.


        :return: The shipping_address of this Order.
        :rtype: Address
        """
        return self._shipping_address

    @shipping_address.setter
    def shipping_address(self, shipping_address: Address):
        """Sets the shipping_address of this Order.


        :param shipping_address: The shipping_address of this Order.
        :type shipping_address: Address
        """

        self._shipping_address = shipping_address

    @property
    def payment_method(self) -> str:
        """Gets the payment_method of this Order.

        Payment method used for the order (e.g., \"Credit Card\", \"PayPal\").  # noqa: E501

        :return: The payment_method of this Order.
        :rtype: str
        """
        return self._payment_method

    @payment_method.setter
    def payment_method(self, payment_method: str):
        """Sets the payment_method of this Order.

        Payment method used for the order (e.g., \"Credit Card\", \"PayPal\").  # noqa: E501

        :param payment_method: The payment_method of this Order.
        :type payment_method: str
        """

        self._payment_method = payment_method

    @property
    def tracking_number(self) -> str:
        """Gets the tracking_number of this Order.

        Tracking number for shipped orders.  # noqa: E501

        :return: The tracking_number of this Order.
        :rtype: str
        """
        return self._tracking_number

    @tracking_number.setter
    def tracking_number(self, tracking_number: str):
        """Sets the tracking_number of this Order.

        Tracking number for shipped orders.  # noqa: E501

        :param tracking_number: The tracking_number of this Order.
        :type tracking_number: str
        """

        self._tracking_number = tracking_number
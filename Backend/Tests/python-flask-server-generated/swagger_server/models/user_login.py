# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class UserLogin(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, email: str=None, password: str=None):  # noqa: E501
        """UserLogin - a model defined in Swagger

        :param email: The email of this UserLogin.  # noqa: E501
        :type email: str
        :param password: The password of this UserLogin.  # noqa: E501
        :type password: str
        """
        self.swagger_types = {
            'email': str,
            'password': str
        }

        self.attribute_map = {
            'email': 'email',
            'password': 'password'
        }
        self._email = email
        self._password = password

    @classmethod
    def from_dict(cls, dikt) -> 'UserLogin':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The UserLogin of this UserLogin.  # noqa: E501
        :rtype: UserLogin
        """
        return util.deserialize_model(dikt, cls)

    @property
    def email(self) -> str:
        """Gets the email of this UserLogin.


        :return: The email of this UserLogin.
        :rtype: str
        """
        return self._email

    @email.setter
    def email(self, email: str):
        """Sets the email of this UserLogin.


        :param email: The email of this UserLogin.
        :type email: str
        """

        self._email = email

    @property
    def password(self) -> str:
        """Gets the password of this UserLogin.


        :return: The password of this UserLogin.
        :rtype: str
        """
        return self._password

    @password.setter
    def password(self, password: str):
        """Sets the password of this UserLogin.


        :param password: The password of this UserLogin.
        :type password: str
        """

        self._password = password

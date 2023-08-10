# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class ReviewUpdate(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, review_id: int=None, status: str=None, admin_comment: str=None, updated_content: str=None):  # noqa: E501
        """ReviewUpdate - a model defined in Swagger

        :param review_id: The review_id of this ReviewUpdate.  # noqa: E501
        :type review_id: int
        :param status: The status of this ReviewUpdate.  # noqa: E501
        :type status: str
        :param admin_comment: The admin_comment of this ReviewUpdate.  # noqa: E501
        :type admin_comment: str
        :param updated_content: The updated_content of this ReviewUpdate.  # noqa: E501
        :type updated_content: str
        """
        self.swagger_types = {
            'review_id': int,
            'status': str,
            'admin_comment': str,
            'updated_content': str
        }

        self.attribute_map = {
            'review_id': 'reviewId',
            'status': 'status',
            'admin_comment': 'adminComment',
            'updated_content': 'updatedContent'
        }
        self._review_id = review_id
        self._status = status
        self._admin_comment = admin_comment
        self._updated_content = updated_content

    @classmethod
    def from_dict(cls, dikt) -> 'ReviewUpdate':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ReviewUpdate of this ReviewUpdate.  # noqa: E501
        :rtype: ReviewUpdate
        """
        return util.deserialize_model(dikt, cls)

    @property
    def review_id(self) -> int:
        """Gets the review_id of this ReviewUpdate.

        Unique identifier for the review being updated.  # noqa: E501

        :return: The review_id of this ReviewUpdate.
        :rtype: int
        """
        return self._review_id

    @review_id.setter
    def review_id(self, review_id: int):
        """Sets the review_id of this ReviewUpdate.

        Unique identifier for the review being updated.  # noqa: E501

        :param review_id: The review_id of this ReviewUpdate.
        :type review_id: int
        """
        if review_id is None:
            raise ValueError("Invalid value for `review_id`, must not be `None`")  # noqa: E501

        self._review_id = review_id

    @property
    def status(self) -> str:
        """Gets the status of this ReviewUpdate.

        The new status for the review.  # noqa: E501

        :return: The status of this ReviewUpdate.
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status: str):
        """Sets the status of this ReviewUpdate.

        The new status for the review.  # noqa: E501

        :param status: The status of this ReviewUpdate.
        :type status: str
        """
        allowed_values = ["approved", "pending", "rejected"]  # noqa: E501
        if status not in allowed_values:
            raise ValueError(
                "Invalid value for `status` ({0}), must be one of {1}"
                .format(status, allowed_values)
            )

        self._status = status

    @property
    def admin_comment(self) -> str:
        """Gets the admin_comment of this ReviewUpdate.

        Optional comment by the administrator regarding the update (e.g., reason for rejection).  # noqa: E501

        :return: The admin_comment of this ReviewUpdate.
        :rtype: str
        """
        return self._admin_comment

    @admin_comment.setter
    def admin_comment(self, admin_comment: str):
        """Sets the admin_comment of this ReviewUpdate.

        Optional comment by the administrator regarding the update (e.g., reason for rejection).  # noqa: E501

        :param admin_comment: The admin_comment of this ReviewUpdate.
        :type admin_comment: str
        """

        self._admin_comment = admin_comment

    @property
    def updated_content(self) -> str:
        """Gets the updated_content of this ReviewUpdate.

        Updated content of the review, if any changes are made to the original review text.  # noqa: E501

        :return: The updated_content of this ReviewUpdate.
        :rtype: str
        """
        return self._updated_content

    @updated_content.setter
    def updated_content(self, updated_content: str):
        """Sets the updated_content of this ReviewUpdate.

        Updated content of the review, if any changes are made to the original review text.  # noqa: E501

        :param updated_content: The updated_content of this ReviewUpdate.
        :type updated_content: str
        """

        self._updated_content = updated_content
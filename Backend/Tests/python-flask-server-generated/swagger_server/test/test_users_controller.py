# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.inline_response200 import InlineResponse200  # noqa: E501
from swagger_server.models.notification import Notification  # noqa: E501
from swagger_server.models.order import Order  # noqa: E501
from swagger_server.models.profile_password_body import ProfilePasswordBody  # noqa: E501
from swagger_server.models.review import Review  # noqa: E501
from swagger_server.models.review_input import ReviewInput  # noqa: E501
from swagger_server.models.user_login import UserLogin  # noqa: E501
from swagger_server.models.user_profile import UserProfile  # noqa: E501
from swagger_server.models.user_registration import UserRegistration  # noqa: E501
from swagger_server.models.users_forgotpassword_body import UsersForgotpasswordBody  # noqa: E501
from swagger_server.models.users_notifications_body import UsersNotificationsBody  # noqa: E501
from swagger_server.models.users_resetpassword_body import UsersResetpasswordBody  # noqa: E501
from swagger_server.models.wishlist import Wishlist  # noqa: E501
from swagger_server.test import BaseTestCase


class TestUsersController(BaseTestCase):
    """UsersController integration test stubs"""

    def test_api_users_forgot_password_post(self):
        """Test case for api_users_forgot_password_post

        Request password reset
        """
        body = UsersForgotpasswordBody()
        response = self.client.open(
            '/api/users/forgot-password',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_login_post(self):
        """Test case for api_users_login_post

        Authenticate a user
        """
        body = UserLogin()
        response = self.client.open(
            '/api/users/login',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_notifications_get(self):
        """Test case for api_users_notifications_get

        Retrieve user's notifications
        """
        query_string = [('status', 'status_example')]
        response = self.client.open(
            '/api/users/notifications',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_notifications_put(self):
        """Test case for api_users_notifications_put

        Mark notifications as read
        """
        body = UsersNotificationsBody()
        response = self.client.open(
            '/api/users/notifications',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_orders_get(self):
        """Test case for api_users_orders_get

        Retrieve user's order history
        """
        query_string = [('page', 56),
                        ('limit', 56),
                        ('status', 'status_example')]
        response = self.client.open(
            '/api/users/orders',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_profile_delete(self):
        """Test case for api_users_profile_delete

        Delete user's account
        """
        response = self.client.open(
            '/api/users/profile',
            method='DELETE')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_profile_get(self):
        """Test case for api_users_profile_get

        Retrieve the authenticated user's profile
        """
        response = self.client.open(
            '/api/users/profile',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_profile_password_put(self):
        """Test case for api_users_profile_password_put

        Change the user's password
        """
        body = ProfilePasswordBody()
        response = self.client.open(
            '/api/users/profile/password',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_profile_put(self):
        """Test case for api_users_profile_put

        Update the authenticated user's profile
        """
        body = UserProfile()
        response = self.client.open(
            '/api/users/profile',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_register_post(self):
        """Test case for api_users_register_post

        Register a new user
        """
        body = UserRegistration()
        response = self.client.open(
            '/api/users/register',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_reset_password_post(self):
        """Test case for api_users_reset_password_post

        Reset user password
        """
        body = UsersResetpasswordBody()
        response = self.client.open(
            '/api/users/reset-password',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_reviews_get(self):
        """Test case for api_users_reviews_get

        Retrieve user's product reviews
        """
        response = self.client.open(
            '/api/users/reviews',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_reviews_post(self):
        """Test case for api_users_reviews_post

        Create a new product review
        """
        body = ReviewInput()
        response = self.client.open(
            '/api/users/reviews',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_wishlists_get(self):
        """Test case for api_users_wishlists_get

        Retrieve user's wishlists
        """
        response = self.client.open(
            '/api/users/wishlists',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_users_wishlists_post(self):
        """Test case for api_users_wishlists_post

        Create a new wishlist
        """
        body = Wishlist()
        response = self.client.open(
            '/api/users/wishlists',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()

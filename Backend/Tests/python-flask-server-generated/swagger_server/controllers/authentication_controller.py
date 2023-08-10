import connexion
import six

from swagger_server.models.api_authorize_body import ApiAuthorizeBody  # noqa: E501
from swagger_server.models.inline_response200 import InlineResponse200  # noqa: E501
from swagger_server import util


def authenticate_user(body):  # noqa: E501
    """Authenticate a user and return a JWT token

    Authenticate with a username and password to receive a JWT token.  This token should be included in the Authorization header for subsequent requests to protected endpoints.  # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: InlineResponse200
    """
    if connexion.request.is_json:
        body = ApiAuthorizeBody.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'

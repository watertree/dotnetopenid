﻿//-----------------------------------------------------------------------
// <copyright file="EndUserAuthorizationImplicitRequest.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2.Messages {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using DotNetOpenAuth.Messaging;
	using DotNetOpenAuth.OAuth2.ChannelElements;

	/// <summary>
	/// A message sent by a web application Client to the AuthorizationServer
	/// via the user agent to obtain authorization from the user and prepare
	/// to issue an access token to the client if permission is granted.
	/// </summary>
	[Serializable]
	public class EndUserAuthorizationImplicitRequest : EndUserAuthorizationRequest, IAccessTokenRequest {
		/// <summary>
		/// Gets or sets the grant type that the client expects of the authorization server.
		/// </summary>
		/// <value>Always <see cref="EndUserAuthorizationResponseType.AccessToken"/>.  Other response types are not supported.</value>
		[MessagePart(Protocol.response_type, IsRequired = true, Encoder = typeof(EndUserAuthorizationResponseTypeEncoder))]
		private const EndUserAuthorizationResponseType ResponseTypeConst = EndUserAuthorizationResponseType.AccessToken;

		/// <summary>
		/// Initializes a new instance of the <see cref="EndUserAuthorizationImplicitRequest"/> class.
		/// </summary>
		/// <param name="authorizationEndpoint">The Authorization Server's user authorization URL to direct the user to.</param>
		/// <param name="version">The protocol version.</param>
		internal EndUserAuthorizationImplicitRequest(Uri authorizationEndpoint, Version version)
			: base(authorizationEndpoint, version) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EndUserAuthorizationImplicitRequest"/> class.
		/// </summary>
		/// <param name="authorizationServer">The authorization server.</param>
		internal EndUserAuthorizationImplicitRequest(AuthorizationServerDescription authorizationServer)
			: this(authorizationServer.AuthorizationEndpoint, authorizationServer.Version) {
		}

		/// <summary>
		/// Gets the grant type that the client expects of the authorization server.
		/// </summary>
		public override EndUserAuthorizationResponseType ResponseType {
			get { return ResponseTypeConst; }
		}

		/// <summary>
		/// Gets a value indicating whether the client requesting the access token has authenticated itself.
		/// </summary>
		/// <value>
		/// Always false because authorization requests only include the client_id, without a secret.
		/// </value>
		bool IAccessTokenRequest.ClientAuthenticated {
			get { return false; }
		}
	}
}

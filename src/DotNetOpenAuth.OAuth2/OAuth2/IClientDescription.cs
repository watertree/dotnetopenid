﻿//-----------------------------------------------------------------------
// <copyright file="IClientDescription.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2 {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.Contracts;

	/// <summary>
	/// A description of a client from an Authorization Server's point of view.
	/// </summary>
	[ContractClass(typeof(IClientDescriptionContract))]
	public interface IClientDescription {
		/// <summary>
		/// Gets the client secret.
		/// </summary>
		string Secret { get; }

		/// <summary>
		/// Gets the callback to use when an individual authorization request
		/// does not include an explicit callback URI.
		/// </summary>
		/// <value>An absolute URL; or <c>null</c> if none is registered.</value>
		Uri DefaultCallback { get; }

		/// <summary>
		/// Gets the type of the client.
		/// </summary>
		ClientType ClientType { get; }

		/// <summary>
		/// Determines whether a callback URI included in a client's authorization request 
		/// is among those allowed callbacks for the registered client.
		/// </summary>
		/// <param name="callback">The absolute URI the client has requested the authorization result be received at.</param>
		/// <returns>
		/// <c>true</c> if the callback URL is allowable for this client; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// At the point this method is invoked, the identity of the client has <em>not</em>
		/// been confirmed.  To avoid open redirector attacks, the alleged client's identity
		/// is used to lookup a list of allowable callback URLs to make sure that the callback URL
		/// the actual client is requesting is one of the expected ones.
		/// </para>
		/// <para>
		/// From OAuth 2.0 section 2.1: 
		/// The authorization server SHOULD require the client to pre-register
		/// their redirection URI or at least certain components such as the
		/// scheme, host, port and path.  If a redirection URI was registered,
		/// the authorization server MUST compare any redirection URI received at
		/// the authorization endpoint with the registered URI.
		/// </para>
		/// </remarks>
		bool IsCallbackAllowed(Uri callback);
	}

	/// <summary>
	/// Contract class for the <see cref="IClientDescription"/> interface.
	/// </summary>
	[ContractClassFor(typeof(IClientDescription))]
	internal abstract class IClientDescriptionContract : IClientDescription {
		#region IClientDescription Members

		/// <summary>
		/// Gets the client secret.
		/// </summary>
		/// <value></value>
		string IClientDescription.Secret {
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets the type of the client.
		/// </summary>
		ClientType IClientDescription.ClientType {
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets the callback to use when an individual authorization request
		/// does not include an explicit callback URI.
		/// </summary>
		/// <value>
		/// An absolute URL; or <c>null</c> if none is registered.
		/// </value>
		Uri IClientDescription.DefaultCallback {
			get {
				Contract.Ensures(Contract.Result<Uri>() == null || Contract.Result<Uri>().IsAbsoluteUri);
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Determines whether a callback URI included in a client's authorization request
		/// is among those allowed callbacks for the registered client.
		/// </summary>
		/// <param name="callback">The requested callback URI.</param>
		/// <returns>
		///   <c>true</c> if the callback is allowed; otherwise, <c>false</c>.
		/// </returns>
		bool IClientDescription.IsCallbackAllowed(Uri callback) {
			Requires.NotNull(callback, "callback");
			Requires.True(callback.IsAbsoluteUri, "callback");
			throw new NotImplementedException();
		}

		#endregion
	}
}

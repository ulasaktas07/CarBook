﻿using CarBook.Aplication.Dtos;
using CarBook.Aplication.Features.Mediator.Results.AppUserResults;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CarBook.Aplication.Tools
{
	public class JwtTokenGenerator
	{
		public static TokenResponseDto GenerateToken(GetCheckAppUserQueryResult result)
		{
			var claims = new List<Claim>();
			if (!string.IsNullOrWhiteSpace(result.Role))
			claims.Add(new Claim(ClaimTypes.Role, result.Role));

			claims.Add(new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()));

			if(!string.IsNullOrWhiteSpace(result.UserName))
				claims.Add(new Claim("Username", result.UserName));

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));

			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.ExpireMinutes);

			var token = new JwtSecurityToken(
				issuer: JwtTokenDefaults.ValidIssuer,
				audience: JwtTokenDefaults.ValidAudience,
				claims: claims,
				notBefore: DateTime.UtcNow,
				expires: expireDate,
				signingCredentials: creds
			);

			var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

			return new TokenResponseDto(jwtToken, expireDate);


		}
	}
}

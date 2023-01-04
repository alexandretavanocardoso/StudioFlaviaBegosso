namespace StudioFlaviaBegosso.Configuration
{
    public static class TokenConfiguration
    {
        public static void AddToken(this IServiceCollection services, WebApplicationBuilder builder)
        {           
            services.AddAuthorization(aut =>
            {
                aut.AddPolicy("AdminPolicy", a => a.RequireAuthenticatedUser()
                                             .RequireClaim("AdminClaim"));
            });
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateActor = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["JwtBearerToken:Issuer"],
                    ValidAudience = builder.Configuration["JwtBearerToken:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtBearerToken:SecretKey"])),
                    ClockSkew = TimeSpan.Zero
                };
            });
        }
    }
}

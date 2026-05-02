using WebApplication1.Data;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimpleController : ControllerBase
    {
        private readonly CoSoDuLieu _context;
        private readonly IConfiguration _configuration;

        public SimpleController(CoSoDuLieu context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public class DangNhapRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        [HttpPost("dangnhap")]
        public IActionResult DangNhap([FromBody] DangNhapRequest request)
        {
            var user = _context.Userss.FirstOrDefault(u => u.Username == request.Username);
            if (user == null) return BadRequest(new { message = "Sai tài khoản hoặc mật khẩu" });

            return Ok(new
            {
                message = "Đăng nhập thành công!",
            });
        }
    }
}
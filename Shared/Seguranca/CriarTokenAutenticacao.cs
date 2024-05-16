using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MSCadastroMedicoPacienteShared.Seguranca;

public class CriarTokenAutenticacao
{
    /// <summary>
    /// Método que retornará o Token do Usuário para Autentica-lo em todos os métodos
    /// </summary>
    /// <param name="cdEmpresa">Informar o ID da Empresa que será gerado o Token</param>
    /// <returns>Retornar um token gerados</returns>
    public static string GerarToken(string token, DateTime dtLimite)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Secreto.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                    new Claim("access_token", token),
            }),
            Expires = dtLimite,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var tokenresult = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(tokenresult);
    }
}

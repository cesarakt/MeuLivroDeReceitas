using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;
using System;
using System.Linq;

namespace MyRecipeBook.application.UseCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRegisteredUserJson Execute(RequestRegisterUserJson request)
        {
            //Validar a request
            Validate(request);

            //Mapear a request em uma entidade

            //Criptografia da senha

            //Salvar no banco de dados
            return new ResponseRegisteredUserJson
            {
                Name = request.Name,
            };
        }
        private void Validate(RequestRegisterUserJson request)
        {
            var validator = new RegisterUserValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false) 
            {
                var errorMessages = result.Errors.Select(e => e.ErrorMessage);

                throw new Exception();
            }
        }
    }
}

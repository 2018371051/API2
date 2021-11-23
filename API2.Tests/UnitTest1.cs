using API2.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace API2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DbUsuarioExists_ReturnsTrue()
        {
            //Arrange
            var usuariosController = new UsuariosController();
            //Act
            var result = usuariosController.DbUsuarioExists(1);
            //Assert
            Assert.IsTrue(result);
        }
        public void DbUsuarioExists_ReturnsFalse()
        {
            //Arrange
            var usuariosController = new UsuariosController();
            //Act
            var result = usuariosController.DbUsuarioExists(0);
            //Assert
            Assert.IsFalse(result);
        }
    }
}

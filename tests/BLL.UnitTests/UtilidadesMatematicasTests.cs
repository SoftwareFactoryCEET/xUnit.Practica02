using System;
using Xunit;

namespace BLL.UnitTests
{
    public class UtilidadesMatematicasTests
    {
        [Fact]
        public void Sumar_ShoulBe5_IfA2AndB3()
        {
            //Arrange
                var a=2;
                var b = 3;
            //Act
            var result = UtilidadesMatematicas.Sumar(a,b);

            //Assert
            Assert.Equal(5,result);
        }


        [Fact]
        public void EsPar_ShouldBeTru_IfA2()
        {
            //Given
            var a = 2;
            //When
            var result = UtilidadesMatematicas.EsPar(a);
            //Then
            Assert.True(result);
        }

        [Fact]
        public void EsPar_ShouldBeTru_IfA1()
        {
            //Given
            var a = 1;
            //When
            var result = UtilidadesMatematicas.EsPar(a);
            //Then
            Assert.False(result);
        }
    }
}

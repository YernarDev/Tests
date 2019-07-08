using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebApplication2;
using Xunit;

namespace WebApplicationTests
{
    //моки - юнит тесты для проверки поведения класса, при симитированных параметрах
    public class AnotherServiceTests
    {
        [Fact]
        void SomeTest()
        {
            //Arrange
            // mock для имитации исходных данных класса            
            var mock = new List<int> { 1, 2, 3, 4, 5 };
            // как правило мок будет имитировать базу данных
            // или имитировать поведение теста, 
            // мок делает тест зависимым(от тестируемого класса, бд итд)
            // поэтому не стоит ими злоупотреблять
            // Один тест - один мок - это край

            AnotherService service = new AnotherService(mock); // передача имитационных данных

            // Act
            var result = service.SomeMethod(); // проверка поведения класса при симитированных параметрах

            // Assert
            Assert.Equal(5, result); // варификация результата
        }
    }
}
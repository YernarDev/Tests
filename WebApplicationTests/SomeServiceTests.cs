using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication2;
using Xunit;

namespace WebApplicationTests
{
    //Стабы - юнит тесты для проверки состояния класса и возвращаемых параметров
    public class SomeServiceTests
    {
        SomeService service;

        public SomeServiceTests()
        {
            //Arrange вынесенный в контроллер
            service = new SomeService();
        }

        [Fact]
        void SomeTest()
        {
            //Arrange если не выносить в контроллер
            SomeService _service = new SomeService();

            //Act
            var res = service.SomeMethod(0);

            //Assert
            Assert.False(res);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(20)]
        [InlineData(30)]
        void SomeTest1(int val)
        {
            //объединенные Act и Assert
            Assert.True(service.SomeMethod(val));

            //Assert.False(service.SomeMethod(val));            
            //Assert.Null();
            //Assert.NotNull();
            //Assert.Contains();
            //Assert.NotContains();
            //Assert.Match();
            //Assert.DoesNotMatch();
            //Assert.IsType();
            //Assert.IsNotType();
            //Assert.InRange();
            //Assert.NotInRange();
        }

        [Fact]
        void SomeTest2()
        {
            //Пример использования All
            List<int> a = new List<int>() { 1, 1, 1 };

            Assert.All(a, item => Assert.Equal(1, item));
        }

        [Fact]
        void SomeTest3()
        {
            //Пример использования Throws
            Assert.Throws<ArgumentNullException>(() => service.SomeMethod1());
        }

        [Fact]
        async Task SomeTest4()
        {
            //Пример использования ThrowsAsync
            await Assert.ThrowsAsync<ArgumentNullException>(() => service.SomeMethod2());
        }

       
    }
}

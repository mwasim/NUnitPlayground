using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    [TestFixture]
    [Category("Object Types and Propreties Tests")]
    public class ObjectTypeAndPropertiesTests
    {
        EmployeeFactory factory;

        [SetUp]
        public void Setup()
        {
            factory = new EmployeeFactory();
        }

        [Test]
        public void ShouldCreateAWorker()
        {
            var emp = factory.GetEmmployee(isManager: false);

            Assert.That(emp, Is.InstanceOf(typeof(Worker)));
            Assert.That(emp, Is.Not.InstanceOf(typeof(Manager)));

            Assert.That(emp, Is.TypeOf<Worker>());
            Assert.That(emp, Is.Not.TypeOf<Manager>());

            Assert.That(emp, Is.TypeOf(typeof(Worker)));
        }

        [Test]
        public void ShouldCreateAManager()
        {
            var emp = factory.GetEmmployee(isManager: true);

            Assert.That(emp, Is.InstanceOf(typeof(Manager)));
            Assert.That(emp, Is.TypeOf<Manager>());
        }

        [Test]
        public void ShouldBeOfBaseType()
        {
            var empWrk = factory.GetEmmployee(isManager: false);
            var empMgr = factory.GetEmmployee(isManager: true);

            Assert.That(empWrk, Is.InstanceOf<Employee>()); //is and instance of the base type also
            Assert.That(empMgr, Is.InstanceOf<Employee>()); //is and instance of the base type also
        }

        [Test]
        public void ManagerShouldBeAbleToManageProjects()
        {
            var empMgr = (Manager)factory.GetEmmployee(isManager: true);

            Assert.That(empMgr.CanManageProjects, Is.True);
        }

        [Test]
        public void ShouldManagerHaveASpecificProperty()
        {
            var empMgr = (Manager)factory.GetEmmployee(isManager: true);

            Assert.That(empMgr, Has.Property("CanManageProjects"));
            //Assert.That(empMgr, Has.Property("CanManageTheBoss")); //fails
        }

        [TearDown]
        public void Teardown()
        {
            factory = null;
        }

    }
}


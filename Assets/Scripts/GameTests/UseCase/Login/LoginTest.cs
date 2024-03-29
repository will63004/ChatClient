﻿using Game.Player;
using NSubstitute;
using NUnit.Framework;
using System;
using UseCase.Login;
using UseCase.Player;

namespace Tests
{
    public class LoginTest
    {
        private IPlayer player;
        private ILogin login;

        private ILoginHandler mock;

        [SetUp]
        public void SetUp()
        {
            player = new Player(new PlayerData());
            mock = Substitute.For<ILoginHandler>();
            login = new Login(player, mock);            
        }

        [Test]
        public void StartLoginTest()
        {
            //Arrange
            ulong playerID = 8763;

            //Act
            login.StartLogin(playerID);
            mock.OnLoginAck += Raise.Event<Action<ulong>>(playerID);

            //Assert
            mock.Received(1).Send(playerID);
            Assert.AreEqual(playerID, player.PlayerID);
        }
    }
}

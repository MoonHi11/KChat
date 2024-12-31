using KayTown.Modelss;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KayTown.Services
{
    public class DatabaseInit
    {
        private readonly SQLiteConnection _database;
        public DatabaseInit(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<User>();
            _database.CreateTable<Chats>();
            _database.CreateTable<Messages>();
            _database.CreateTable<ChatParticipants>();
        }



        //USERs CRUD CONTROL SECTION


        //Create Users
        public void AddUser(User user)
        {
            _database.Insert(user);
        }

        //Read All User
        public List<Chats> GetChats()
        {
            return
           _database.Table<Chats>().ToList();
        }

        public List<User> GetAllUsers()
        {
            return
          _database.Table<User>().ToList();
        }

        public User GetUserById(string userId)
        {
            return _database.Table<User>().FirstOrDefault(u => u.UserID == userId);
        }

        //Update modify user data
        public void UpdateUser(User user)
        {
            _database.Update(user);
        }

        // Delete remove a user
        public void DeleteUser(string userId)
        {
            var user = GetUserById(userId);
            if (user != null)
            {
                _database.Delete(user);
            }
        }



        //CHAT CRUD CONTROL SECTIONS


        //create chat
        public void AddChat(Chats chat)
        {
            _database.Insert(chat);
        }

        //read all chat
        public List<Chats> GetAllChats()
        {
            return
           _database.Table<Chats>().ToList();
        }

        public Chats GetChatById(string chatId)
        {
            return _database.Table<Chats>().FirstOrDefault(u => u.ChatID == chatId);
        }

        //Update modify chat data
        public void UpdateChat(Chats chat)
        {
            _database.Update(chat);
        }

        // Delete chat
        public void DeleteChat(string chatId)
        {
            var chat = GetChatById(chatId);
            if (chat != null)
            {
                _database.Delete(chat);
            }
        }



        //MESSAGE CRUD CONTROL SECTIONS


        //create message
        public void AddMessage(Messages message)
        {
            _database.Insert(message);
        }

        //read all message
        public List<Messages> GetAllMessage()
        {
            return
           _database.Table<Messages>().ToList();
        }

        public Messages GetMessageById(string messageId)
        {
            return _database.Table<Messages>().FirstOrDefault(m => m.MessageID == messageId);
        }

        //Update modify message data
        public void UpdateMessage(Messages message)
        {
            _database.Update(message);
        }

        // Delete message
        public void DeleteMessage(string messageId)
        {
            var message = GetMessageById(messageId);
            if (message != null)
            {
                _database.Delete(message);
            }
        }



        //PARTICIPANT CRUD CONTROL SECTIONS


        //create chat
        public void AddParticipant(ChatParticipants participant)
        {
            _database.Insert(participant);
        }

        //read all chat
        public List<ChatParticipants> GetAllParticipant()
        {
            return
           _database.Table<ChatParticipants>().ToList();
        }

        public ChatParticipants GetParticipantById(string chatId)
        {
            return _database.Table<ChatParticipants>().FirstOrDefault(p => p.ChatId == chatId);
        }

       
        // Delete chat
        public void DeleteParticipant(string chatId, string userId)
        {
            var participant = _database.Table<ChatParticipants>().FirstOrDefault(p => p.ChatId == chatId && p.UserId == userId);
            if (participant != null)
            {
                _database.Delete(participant);
            }
        }

    }
}

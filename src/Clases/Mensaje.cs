﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter.Clases
{
    public class Mensaje
    {
        int id_receiver;
        int id_sender;
        string message;

        public Mensaje(int id_receiver, int id_sender, string message)
        {
            this.id_receiver = id_receiver;
            this.id_sender = id_sender;
            this.message = message;
        }

        public static void EnviarMensaje(Mensaje chat)
        {
            string query = "INSERT INTO `pet4sitter`.`chat` (`id_receiver`, `id_sender`, `messages`) VALUES (@id_receiver, @id_sender, @mensaje);";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("id_receiver",chat.id_receiver);
            com.Parameters.AddWithValue("id_sender", chat.id_sender);
            com.Parameters.AddWithValue("mensaje", chat.message);
            com.ExecuteNonQuery();
        }
    }
}

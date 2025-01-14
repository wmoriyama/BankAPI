﻿using Infra.DataBase;
using Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositorie
{
    public static class MySqlRepositorie
    {
        public static Empresa GetEmpresa(int id)
        {
            using (var context = new MySqlDbContext())
            {
                var empresas = context.Empresa;
                return empresas.FirstOrDefault(emp => emp.Id == id);
            }
        }

        public static bool AddEmpresa(Empresa empresa)
        {
            try
            {
                using (var context = new MySqlDbContext())
                {
                    context.Empresa.Add(empresa);
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool UpdateEmpresa(Empresa empresa)
        {
            try
            {
                using (var context = new MySqlDbContext())
                {
                    context.Empresa.Update(empresa);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static Retorno GetRetorno(int id)
        {
            using (var context = new MySqlDbContext())
            {
                var retornos = context.Retorno;
                return retornos.FirstOrDefault(ret => ret.Id == id);
            }
        }

        public static List<Retorno> GetAllRetorno()
        {
            using (var context = new MySqlDbContext())
            {
                return context.Retorno.ToList();
            }
        }

        public static bool AddRetorno(Retorno retorno)
        {
            try
            {
                using (var context = new MySqlDbContext())
                {
                    context.Retorno.Add(retorno);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

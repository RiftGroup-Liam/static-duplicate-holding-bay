using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using Rift.UK.Core.RGI2.REO.SerializationObjects;
using Rift.UK.Core.RGI2.REO;

namespace Rift.UK.Client.RGI2.Connector.Helper_Classes
{
    public static class SerializationHelper
    {
        public static string SerializeGetMatchingDetailsSO(GetMatchingDetailsSO obj)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(GetMatchingDetailsSO));
                ser.WriteObject(stream, obj);
                string serializedObject = Encoding.UTF8.GetString(stream.ToArray());
                return serializedObject;
            }
            catch (Exception ex) { throw ex; }
        }

        public static string SerializeImportContactSO(ImportContactSO obj)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ImportContactSO));
                ser.WriteObject(stream, obj);
                string serializedObject = Encoding.UTF8.GetString(stream.ToArray());
                return serializedObject;
            }
            catch (Exception ex) { throw ex; }
        }

        public static string SerializeCreateHistoryRecordForRiftIdSO(CreateHistoryRecordForRiftIdSO obj)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CreateHistoryRecordForRiftIdSO));
                ser.WriteObject(stream, obj);
                string serializedObject = Encoding.UTF8.GetString(stream.ToArray());
                return serializedObject;
            }
            catch (Exception ex) { throw ex; }
        }

        public static string SerializeDeletePossibleDuplicateSO(DeletePossibleDuplicateSO obj)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DeletePossibleDuplicateSO));
                ser.WriteObject(stream, obj);
                string serializedObject = Encoding.UTF8.GetString(stream.ToArray());
                return serializedObject;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

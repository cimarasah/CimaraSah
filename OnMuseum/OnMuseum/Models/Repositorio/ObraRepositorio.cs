using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using OnMuseum.Models.Basic;
using MessagingToolkit.QRCode.Codec;
using OnMuseum.Models.DAO;

namespace OnMuseum.Models.Repositorio
{
    public class ObraRepositorio
    {
        ObraDAO dao = new ObraDAO();
        Random randNum = new Random();
        public ObraBasic InserirObra(ObraBasic obra)
        {                      
            obra.AutorId = 1;
            dao.Inserir(obra);
            return obra;
        }
        public Image GerarQR(int idObra, int qrlevel)
        {

            string toenc = idObra.ToString();

            QRCodeEncoder qe = new QRCodeEncoder();

            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;

            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L; // - Using LOW for more storage

            qe.QRCodeVersion = qrlevel;

            Bitmap bm = qe.Encode(toenc);

            return bm;

        }
    }
}
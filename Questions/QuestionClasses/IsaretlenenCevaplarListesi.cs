using System.Collections.Generic;
using MongoDB.Bson;

namespace Question_Answer.Questions.QuestionForms;

class IsaretlenenCevaplarListesi
{
    public List<ObjectId> SelectedAnswerIdList;

    public IsaretlenenCevaplarListesi()
    {
        SelectedAnswerIdList = new List<ObjectId>();
    }
}
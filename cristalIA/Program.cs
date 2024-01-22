using OpenAI_API;
try
{
    var openIA = new OpenAIAPI("");
    var chat = openIA.Chat.CreateConversation();

    chat.AppendSystemMessage("De 3 exemplos de crimes contra animais");
    string resposta = await chat.GetResponseFromChatbotAsync();
    Console.WriteLine(resposta);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
use Millionaire
bulk insert Questions
from 'E:\Шаг ДЗ\Windows Forms\Проекты\Millionaire\question.txt'
with (
      FIELDTERMINATOR ='|',  
      ROWTERMINATOR = '\n');
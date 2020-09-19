
import enchant
from enchant.checker import SpellChecker
c = enchant.Dict("ru_RU")
chkr = SpellChecker("ru_RU")
res = open("check_string_2.txt","w")
i = 0
with open("E:/3 course (inst)/Defence X/bruted_full_2_4.txt","r") as file:
    for word in file:
        i = i + 1
        print(i)
        word = word.strip()
        chkr.set_text(word)
        j = 0
        for err in chkr:
            print("ERROR:", err.word)
            j+=1
        if j == 0: 
            res.write(word)
            break
res.close()

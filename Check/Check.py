
import enchant
c = enchant.Dict("ru_RU");
res = open("check_7.txt","w")
i = 0
with open("E:/3 course (inst)/Defence X/bruted.txt","r") as file:
    for word in file:
        i=i+1
        print(i)
        if c.check(word.strip('\n')):
           res.write(word);

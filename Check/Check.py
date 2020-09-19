
import enchant
c = enchant.Dict("ru_RU");
res = open("check_middle_.txt","w")
i = 0
with open("E:/3 course (inst)/Defence X/bruted_middle.txt","r") as file:
    for word in file:
        i=i+1
        print(i)
        word.strip('\n')
        if c.check(word.strip('\n')):
           res.write(word);


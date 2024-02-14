# IELTS band Scores: How they are calculated

The IELTS band score tables below explain the scoring to help you calculate and understand your score. Understanding the requirements for your target score is essential for success in IELTS.

# How the IELTS Band Scores are Calculated

All IELTS scores are between 0 and 9. You can also get .5 sores as well (for example, 6.5 or 7.5). You will get a band score for each skill (listening, reading, writing, and speaking) and also an overall band score. The overall band score is the average score of all the skills. See the table bellow as an example.

| Listening | Reading | Writing | Speaking | Overall |
|:---------:| :--------:|:--------:|:---------:|:--------:|
|    8      |   7.5   |   7     |    7.5   |  7.5    | 



AS explained on the IELTS website, overall test results are calulated to the nearest 0.5 or nearest whole band score. This means if the final score is not a precise 7.5 (as shown in the table above), your score is pushed to the nearest whole score or half score depending which is nearest. Below you can see examples of how this works according to IELTS.

* If your overall score is 6.1 you score will go down to 6. This is the nearest whole band score. In other words, 6.1 is closer ot band 6 than to 6.5
* if your overall score is calculated to be 6.85, your final result will be band 7. This is because 6.85 is closer to band 7 than to band 6.5

* If your overall score is an average 6.2, your score will be increased to 6.5. The score 6.25 is actually precisely between band 6 and 6.5, so in this case IELTS will push it up to the nearest score which is 6.5
* If your overall score is an average of 6.75, your score will be increased to 7. This score again is precisely between 6.5 and band 7. In this case, your score will be rounded up to band 7.



# IELTS Avarage Score Calculator Program 
# 1. Input data from User
Listening Score Input: The program prompts the user to enter their listening score.

Reading Score Input: The user is asked to input their reading score.

Speaking Score Input: The program collects the speaking score from the user.

Writing Score Input: Finally, the user is prompted to provide their writing score.

![](../IELTSAvarageScoreCalculator/assets/images/inputuser.png)

# 2. Converting all data to decimal type
Reading Score: The readingScoreInput is converted to a decimal and added to the scores array.
Listening Score: Similarly, the `listeningScoreInput` is converted and included in the scores.
Writing Score: The `writingScoreInput` is also converted and appended to the scores.
Speaking Score: Lastly, the `speakingScoreInput` is converted and added to the scores.

![](../IELTSAvarageScoreCalculator/assets/images/convert.png)

# 3. Calculating average score
Average Calculation: The average IELTS score is computed using the Average() method on the scores array.
Remainder Calculation: The decimal part of the average score is extracted by subtracting the integer part from the average.
Rounding Logic:
If the remainder is less than 0.25, it is rounded down to the nearest whole number.
If the remainder is between 0.25 and 0.75, it is rounded to the nearest half (e.g., 0.5).
Otherwise, the remainder is rounded up to the next whole number.
Final Average Score: The integer part of the average score is added to the rounded remainder to obtain the final average IELTS score.
The program then prints the result: “Average score: {averageScore}”. 📊


![](../IELTSAvarageScoreCalculator/assets/images/calculteAverageScore.png)

# 4. Demo


![](../IELTSAvarageScoreCalculator/assets/images/demo2.png)

if you like this kind of simple projects you can see this git hub account: https://github.com/Yaqubaliy02.



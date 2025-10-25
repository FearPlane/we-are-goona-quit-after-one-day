what i have tried to do
is taking the current input from the editor (the effect type enum)
and then show the other variables inside the script by the input result of the effectType
because most of the variables like the EffectStatus need like this special condition that will show only when statusCondition is been selected

show i have tried to do the attribute *condition* inside the Effects class itself when the live variables is being changed (well when it accsuly an instance that being called from the monobehviour)
example

public class Effects //Todo find the formulas for the effects and each stats
    {
        public EffectType type; //The kind of effect
        
        [ShowIf(type.)]
        public EffectStatus status; //Which status condition to apply (only for statusCondition)
        public BattleStat stat; //Which stat to modify (only for `statChange`)
    }
    
i have tried to take the values on live from the EffectType
but the two variables in the same spot and being changed only by the other script from the monobheviour 
that mean i cant get on live the values like the plan i have tried 


***** so what i need to do is getting the values using the editor *live from the inspector*
because the variables are all public and on the same place so i cant get the values before starting the game
the editor give you that live values (using monobhevbiour)





i have tried to understand the stuff using only google which i have failed and moved again to chatgpt 
so i didnt make any much progress
instead of trying to understand via chatgpt 
i would recomand for you to start understanding using google so dont give up

now what i have tried is to communicate with the target of the attribute which in my case is Effects script 
and i have tried to use its variables 
but it dont really let me do it freely when i am trying to get the 
instance of effects the monobevhiour class is using into the Editor script
then i can get the data i want freely and live
# CaliburnExamples

*This repo contains* ***Introductory-Level example projects*** *that use the* ***[Caliburn.Micro](http://caliburnmicro.codeplex.com/)*** *open source framework.*

*This README tries to explain what the Caliburn.Micro framework is, and why you should use it.*

----------
### Who is the Main Creator of the Caliburn.Micro framework?

[Let's start with a *tiny* bit of background on the creator of Caliburn.Micro.](http://www.youtube.com/watch_popup?v=dy_DASt7hDs)

Assuming that you clicked the link above and watched the awesome Breaking Bad clip - his name is actually [Eisenburg. Rob Eisenberg](https://twitter.com/EisenbergEffect) (without an "H").

![](http://www.dotnetrocks.com/dnr_photos/RobEisenberg.jpg)

Rob specializes in .NET and C# with a major focus on WPF and Silverlight. He speaks at events, publishes technical articles, and event [writes books](http://www.amazon.com/Sams-Teach-Yourself-WPF-Hours/dp/0672329859).

If you have an extra hour or so and are not familiar with the MVVM pattern, check out [this cool Mix10 talk](http://channel9.msdn.com/Events/MIX/MIX10/EX15) that Rob presented about building your own MVVM framework. But don't forget to come back to finish reading ridiculously awesome README too!  

## Caliburn.Micro - a really cool framework

### What exactly is Caliburn.Micro?

From the documentation at [http://caliburnmicro.codeplex.com/ ](http://caliburnmicro.codeplex.com/):
> Caliburn.Micro is a small, yet powerful framework, designed for building applications across all XAML platforms. With strong support for MVVM and other proven UI patterns, Caliburn.Micro will enable you to build your solution quickly, without the need to sacrifice code quality or testability.

Caliburn.Micro is exactly that - a "micro" version of Caliburn v2. Again from the documentation:

> My vision was to take 90% of Caliburn’s features and squash them into 10% of the code.
> ...
>  I continued along those lines until I had what I felt was a complete solution that mirrored the full version of Caliburn v2, but on a smaller scale.

Rob lists these as the greatest features:

-  ActionMessages 
-  Action Conventions
-  Binding Conventions
-  Screens and Conductors
-  Event Aggregator
-  Coroutines
-  ViewLocator
-  ViewModelLocator
-  WindowManager
-  PropertyChangedBase and BindableCollection
-  Bootstrapper
-  Logging
-  MVVM and MVP

To learn about this list in much greater detail, [check out the Documentation](http://caliburnmicro.codeplex.com/wikipage?title=Introduction&referringTitle=Documentation).

##### A Brief note about MVVM...
While Caliburn supports many "proven UI patterns", the projects in this repository use MVVM. If you're not familiar with the [MVVM pattern](http://en.wikipedia.org/wiki/Model_View_ViewModel) (*and/or were too lazy to watch the [Build Your Own MVVM Framework video](http://channel9.msdn.com/Events/MIX/MIX10/EX15) mentioned above*), it is an architectural pattern (similar to MVC) that promotes a clean separation of concerns between the view and the data model. MVVM is targeted toward .NET platforms like WPF and Silverlight that use XAML.

It stands for:

-  Model
-  View
-  ViewModel (*You can think of this one as a Model specifically for the View*)

##### ViewModel First!
You'll see the term "ViewModel-First" used a lot in the Caliburn documentation and tutorials you see online. Caliburn.Micro "prefers this approach". This simply means that you create a ViewModel first, then create a View that responds to changes in your ViewModel's properties.

This is apposed to a "View-First" approach, in which you would create a view which then creates its own ViewModel.

### Why Use Caliburn.Micro?
Didn't you see the feature list above, and actually go look at the documentation? (tsk tsk)

Just to re-emphasize, there are many benefits to using Caliburn.Micro in your .NET application.

- Code faster
- Code quality
- Testability

The documentation is fantastic. The codebase is small and easy to learn. So the real question is - **Why Not?**

And that's a rhetorical question. So use it!

## The Projects

The projects in this repository demonstrate some simple concepts using Caliburn.Micro. Thus far, they include:

- A basic example of Data Binding and Events 

- A basic example with Event Aggregators

- A basic example Screen Conductor

- A basic example WindowManager

In addition to referencing the online documentation, these basic examples were created by following an absolutely fantastic 6 part [Caliburn.Micro tutorial](https://www.mindscapehq.com/blog/index.php/2012/01/12/caliburn-micro-part-1-getting-started/) by a fine gentleman named Jason. The tutorial was a great to help in getting started using Caliburn.Micro.

Hope you enjoy!
# What is WiX?

WiX or its fullname WiX Toolset is a tool that allow us developer to create installer for Windows installer.

# Why use WiX instead of building your own?

1. Mature and Reliable
   - WiX is a well-established, open-source project backed by Microsoft and other companies.
   - Compare to alternative, WiX is the one that is still being maintained.
2. Standards-Compliant
   - WiX creates installers that follow the Windows Installer (MSI) standard, ensuring compatibility with enterprise deployment tools and IT policies.
3. Not re-invent the technology
   - Installers are one of those things that you work with it until it statisfied it needs and no one ever touched it again.
   - Thus, we don't want to spend significant time to solve things that's already been solved.
4. It's Open-source!

# How do I work with WiX?

- To work with WiX, you will be writing XML files with `.wxs` file extension.
- These files will be use to customize your WiX installer, for example,
  - Indicate files and folder you want to inlcude when installed?
  - Indicate dialogs order when installing
  - And more!

# Let's create your first installer

## Scenario

Your build a console application that will always answers your question with either `yes`, `no`, `Do it!`, or `Nope`.

Let's called it `Sir Answers-a-Lot`.

### Your goal?

1. We want an installer that user can double-click it and it installed.
2. We want user to be able to customize where to install the program.
3. We don't want to get into trouble, so we will also include a user term agreement to avoid lawsuit.
4. We want to ask user if user want a shortcut or not after finishing installing.
5. Lastly, we want to make sure if user can uninstall it, if they don't want to use our program anymore 😭.

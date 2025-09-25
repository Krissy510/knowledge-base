# What is WiX?

- WiX or its fullname WiX Toolset is a tool that allow us developer to create installer for Windows installer.

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

# Scenario

You builded a console application that will always answers your question with

- `Yes`
- `No`
- `Maybe`
- `Definitely`
- `Nope`

Let's called it `Sir Answers-a-Lot`.

## Your goal?

1. We want an installer that install, that's it. [Goal 1](Goal-1.md)
2. We don't want to get into trouble, so we will include a user term agreement to avoid lawsuit. [Goal 2](Goal-2.md)
3. We want user to be able to customize where to install the program.[Goal 3](Goal-3.md)
4. We want to create shortcuts for user. [Goal 4](Goal-4.md)

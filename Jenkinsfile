pipeline{
    agent any
    stages{

        stage("Restore dependencies") {
          steps {
            echo "Restoring dependencies..."
            bat "dotnet restore"
          }
        }

        stage("Build app") {
          steps {
            echo "Building app..."
            bat "dotnet build"
          }
        }

        stage("Run the tests") {
          steps{
            echo "Running the tests..."
            bat "dotnet test"
          }
        }
    }
}

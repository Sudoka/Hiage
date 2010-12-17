using System;
using System.Collections.Generic;
using Engine;

namespace Mario
{
	//A generic game object class
	public abstract class GameObject : ICollidable
	{
		Renderer renderer;
		IController controller;
		protected Vector accelVector = new Vector(0, 0);
		protected double remainingFrameTime = 1;
		protected double animationSpeedFactor = 1;
		protected double frameTime;

		private double left, right;
		private bool cachedLeft, cachedRight;
		
		//States. These may be used for animation etc.
		protected delegate void ObjectState();
		protected List<ObjectState> objectStates = new List<ObjectState>();
		protected int currentState = -1;
		
		//Construct a game object. Set controller to null if the object should be static.
		public GameObject(Vector position, Vector velocity, Sprite sprite, Renderer renderer, IController controller)
		{
			Sprite = sprite;
			Velocity = velocity;
			Position = position;
			this.renderer = renderer;
			this.controller = controller;
			
			SetupStates();
		}
		
		protected abstract void SetupStates();
		
		//Add a new state to this object
		protected int AddState(ObjectState state)
		{
			objectStates.Add(state);
			return objectStates.Count-1;
		}
		
		protected void OverloadState(int stateID, ObjectState state)
		{
			objectStates[stateID] = state;
		}
		
		public void Prepare(double frameTime)
		{
			this.frameTime = frameTime;
			cachedLeft = false;
			cachedRight = false;
		}
		
		//Update this object's position and such
		public virtual void Update(double frameTime)
		{
			Position += Velocity*frameTime*remainingFrameTime;


			Velocity += accelVector*frameTime;
						
			accelVector.X = 0;
			accelVector.Y = 0;
			
			if (controller != null)
				controller.Control(this);

			remainingFrameTime = 1;
			
			//Run the current object state
			if (currentState != -1)
				objectStates[currentState]();
		}
		
		#region ICollidable specifics
		//Bounding box before update
		public BoundingBox BoundingBox
		{
			get
			{
				return new BoundingBox(Position.X - Width/2, Position.Y + Height / 2, Position.X + Width / 2, Position.Y - Height / 2);
			}
		}
		
		//Returns a bounding box covering all the potential area where collisions may occur
		public BoundingBox GetCollisionCheckArea(double frameTime)
		{
			double dx = Math.Abs(Velocity.X)*frameTime;
			double dy = Math.Abs(Velocity.Y)*frameTime;
			return new BoundingBox(BoundingBox.Left-dx,
			                   	   BoundingBox.Top+dy, 
			                       BoundingBox.Right+dx, 
			                       BoundingBox.Bottom-dy);
		}

		public virtual void Collide(Edge e, CollisionResult collisionResult)
		{
			if (controller != null)
				controller.HandleCollision(this, e, collisionResult);
		}
		
		public virtual void Collide(ICollidable o, Vector edgeNormal, CollisionResult collisionResult)
		{
			if (controller != null)
				controller.HandleCollision(this, (GameObject)o, collisionResult);
		}
		#endregion

		#region Control
		
		public abstract void UpAction();		
		public abstract void LeftAction();
		public abstract void DownAction();
		public abstract void RightAction();
		
		#endregion
		
		public void Render(double frameTime)
		{
			Sprite.X = Position.X;
			Sprite.Y = Position.Y;
			Sprite.Update(frameTime*animationSpeedFactor);
			
			//Debug
			/*BoundingBox ca = GetCollisionCheckArea(frameTime);
			renderer.SetDrawingColor(1,0,0,1);
			renderer.DrawSquare(ca.Left, ca.Top, ca.Right, ca.Bottom);
			renderer.SetDrawingColor(1,1,1,1);*/
			
			//renderer.DrawSquare(Position.X-Width/2, Position.Y-Height/2, Position.X+Width/2, Position.Y+Height/2);
			
			renderer.Render(Sprite);
		}			
		
		public void Accellerate(Vector accelVector)
		{
			this.accelVector += accelVector;
		}
		
		//Current velocity
		public Vector Velocity
		{
			get;
			protected set;
		}
		
		//Current position
		public Vector Position
		{
			get;
			protected set;
		}

		//Dimensions
		public abstract int Width
		{ 
			get;
			protected set;
		}
		
		public abstract int Height
		{ 
			get;
			protected set;
		}
		
		public double Left
		{
			get 
			{ 
				if (!cachedLeft)
				{
					left = Math.Min(Position.X - Width/2, Position.X - Width / 2 + Velocity.X*frameTime); 
					cachedLeft = true;
				}
				
				return left;
			}
		}
		
		public double Right
		{
			get 
			{ 
				if (!cachedRight)
				{
					right = Math.Max(Position.X + Width/2, Position.X + Width / 2 + Velocity.X*frameTime); 
					cachedRight = true;
				}
				
				return right;
			}
		}
	
		//Sprite to draw
		protected Sprite Sprite
		{
			get;
			private set;
		}
		
		//Set to true to delete this object next frame
		public bool Delete
		{
			get;
			set;
		}
	}
}
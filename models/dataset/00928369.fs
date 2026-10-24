FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(-11.472769099149065, 20.45951195475467) * mm, "end": v(-48.36330411958765, 25.667586910311215) * mm});
            skLineSegment(sketch, "E1", {"start": v(-48.36330411958765, 25.667586910311208) * mm, "end": v(-21.888921893965517, 0) * mm});
            skLineSegment(sketch, "E2", {"start": v(-21.888921893965506, 0) * mm, "end": v(-38.22336108319149, -35.11796726572548) * mm});
            skLineSegment(sketch, "E3", {"start": v(-38.22336108319149, -35.11796726572548) * mm, "end": v(-4.494119027897491, -17.784708396652817) * mm});
            skLineSegment(sketch, "E4", {"start": v(-4.494119027897487, -17.784708396652828) * mm, "end": v(22.32390403353883, -42.53401890366494) * mm});
            skLineSegment(sketch, "E5", {"start": v(22.323904033538827, -42.53401890366494) * mm, "end": v(16.850015070155592, -6.50025521952537) * mm});
            skLineSegment(sketch, "E6", {"start": v(16.85001507015561, -6.500255219525379) * mm, "end": v(48.894309255316415, 11.730975176600294) * mm});
            skLineSegment(sketch, "E7", {"start": v(48.89430925531642, 11.730975176600303) * mm, "end": v(12.744175164150876, 17.124695023946217) * mm});
            skLineSegment(sketch, "E8", {"start": v(12.744175164150876, 17.124695023946234) * mm, "end": v(5.565445463505219, 54.78498274825333) * mm});
            skLineSegment(sketch, "E9", {"start": v(5.565445463505216, 54.784982748253334) * mm, "end": v(-11.472769099149065, 20.45951195475467) * mm});
            skCircle(sketch, "E10", {"center": v(0, 0) * mm, "radius": 150 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E11.bottom", {"start": v(165.43087363243103, -160.0722223520279) * mm, "end": v(-165.43087363243103, -160.0722223520279) * mm});
            skLineSegment(sketch, "E11.top", {"start": v(165.43087363243103, 160.0722223520279) * mm, "end": v(-165.43087363243103, 160.0722223520279) * mm});
            skLineSegment(sketch, "E11.left", {"start": v(165.43087363243103, -160.0722223520279) * mm, "end": v(165.43087363243103, 160.0722223520279) * mm});
            skLineSegment(sketch, "E11.right", {"start": v(-165.43087363243103, -160.0722223520279) * mm, "end": v(-165.43087363243103, 160.0722223520279) * mm});
            skPoint(sketch, "E11.middle", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F1.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F1.wireOp",EDGE,"E11.bottom")}),-1.0]])]});
            extrude(context, id + "F2", {"entities" : qUnion([Q0]), "depth" : 0 * mm, "offsetDistance" : 25 * mm, "hasSecondDirection" : true, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : 18 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),-1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "depth" : 0 * mm, "offsetDistance" : 25 * mm, "hasSecondDirection" : true, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : 15 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.boolean.opBoolean","COPY",FACE,{"derivedFrom":makeQuery(id+"F3.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4"),sQuery(id+"F0.wireOp",EDGE,"E5"),sQuery(id+"F0.wireOp",EDGE,"E6"),sQuery(id+"F0.wireOp",EDGE,"E7"),sQuery(id+"F0.wireOp",EDGE,"E8"),sQuery(id+"F0.wireOp",EDGE,"E9"),sQuery(id+"F0.wireOp",EDGE,"E10")])],"isStart":true})});
            fillet(context, id + "F4", {"entities" : qUnion([Q0]), "radius" : 26.55634918610405 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
    });